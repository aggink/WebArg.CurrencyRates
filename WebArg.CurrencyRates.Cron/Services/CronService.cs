using Microsoft.Extensions.Logging;
using System.Globalization;
using WebArg.CurrencyRates.Cron.DtoModels;
using WebArg.CurrencyRates.Cron.Exceptions;
using WebArg.CurrencyRates.Cron.Extensions;
using WebArg.CurrencyRates.Cron.Interfaces.Services;
using WebArg.CurrencyRates.Cron.Refit;

namespace WebArg.CurrencyRates.Cron.Services;

/// <summary>
/// Получение данных о курсе чешской кроны
/// </summary>
public sealed class CronService : ICronService
{
    private readonly IApiCronService _apiCronService;
    private readonly ILogger<CronService> _logger;

    public CronService(
        IApiCronService apiCronService,
        ILogger<CronService> logger)
    {
        _apiCronService = apiCronService;
        _logger = logger;
    }

    public async Task<ReportDailyDto> GetReportAsync(DateOnly date, CancellationToken cancellationToken)
    {
        var response = await _apiCronService.GetDailyReport(date.ToString(), cancellationToken);
        response.RefitResponseValidate(_logger);

        return Parse(response.Content);
    }

    /// <summary>
    /// Распарсить отчет от API чешского банка с данными о курсе чешской кроны
    /// </summary>
    /// <param name="report">Отчет о курсе чешской кроны</param>
    /// <returns>Отчет о курсе чешской кроны</returns>
    private ReportDailyDto Parse(string report)
    {
        try
        {
            var dateSpan = report.AsSpan(0, report.IndexOf('#') - 1);
            var date = DateOnly.Parse(dateSpan);

            var reportSpan = report.AsSpan(report.IndexOf('\n') + 1);
            reportSpan = reportSpan[(reportSpan.IndexOf('\n') + 1)..];

            var result = new List<ReportDataDto>();
            while (!reportSpan.IsEmpty)
            {
                var data = reportSpan[..reportSpan.IndexOf('\n')];
                var country = data[..data.IndexOf('|')];

                data = data[(data.IndexOf('|') + 1)..];
                var currency = data[..data.IndexOf('|')];

                data = data[(data.IndexOf('|') + 1)..];
                var amount = int.Parse(data[..data.IndexOf('|')]);

                data = data[(data.IndexOf('|') + 1)..];
                var code = data[..data.IndexOf('|')];

                data = data[(data.IndexOf('|') + 1)..];
                var rate = decimal.Parse(data, NumberStyles.Any, CultureInfo.InvariantCulture);

                result.Add(new ReportDataDto()
                {
                    Amount = amount,
                    Code = new string(code),
                    Rate = rate / amount,
                    Currency = new string(currency),
                    Country = new string(country)
                });

                reportSpan = reportSpan[(reportSpan.IndexOf('\n') + 1)..];
            }

            return new ReportDailyDto
            {
                Date = date,
                Reports = result.ToArray()
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Не удалось распарсить отчет с данными о курсе чешской кроны");
            throw new CronException("Произошла ошибка при попытки обработать данные от API чешского банка", ex);
        }
    }
}
