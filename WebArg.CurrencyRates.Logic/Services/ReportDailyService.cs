using Microsoft.EntityFrameworkCore;
using WebArg.CurrencyRates.Cron.Interfaces.Services;
using WebArg.CurrencyRates.Logic.DtoModels;
using WebArg.CurrencyRates.Logic.Interfaces.Repositories;
using WebArg.CurrencyRates.Logic.Interfaces.Services;
using WebArg.CurrencyRates.Storage.Database;
using WebArg.CurrencyRates.Storage.Models;

namespace WebArg.CurrencyRates.Logic.Services;

/// <summary>
/// Сервис обработки данные для <see cref="ReportDaily"/>
/// </summary>
public class ReportDailyService : IReportDailyService
{
    private readonly IRepository _repository;
    private readonly ICronService _cronService;

    public ReportDailyService(
        IRepository repository,
        ICronService cronService)
    {
        _repository = repository;
        _cronService = cronService;
    }

    public async Task<ReportDto[]> GetReportAsync(DataContext dataContext, DateOnly start, DateOnly end, string[] codes, CancellationToken cancellationToken = default)
    {
        var reports = await dataContext.Reports
            .AsNoTracking()
            .Where(x => codes.Contains(x.Code) && x.Date >= start && x.Date <= end)
            .GroupBy(x => x.Code)
            .Select(x => new ReportDto
            {
                Code = x.Key,
                Avg = x.Average(e => e.Rate),
                Max = x.Max(e => e.Rate),
                Min = x.Min(e => e.Rate)
            })
            .ToArrayAsync(cancellationToken);

        return reports;
    }

    public async Task DownloadReportAsync(DataContext dataContext, DateOnly start, DateOnly end, CancellationToken cancellationToken = default)
    {
        foreach (var day in GetDays(start, end))
        {
            var report = await _cronService.DownloadReportAsync(day, cancellationToken);
            await _repository.AddReportAsync(dataContext, report, cancellationToken);
        }
    }

    /// <summary>
    /// Получить список дат
    /// </summary>
    /// <param name="start">Начало периода</param>
    /// <param name="end">Конец периода</param>
    /// <returns>Список дат</returns>
    private IEnumerable<DateOnly> GetDays(DateOnly start, DateOnly end)
    {
        while (start <= end)
        {
            yield return start;
            start = start.AddDays(1);
        }
    }
}
