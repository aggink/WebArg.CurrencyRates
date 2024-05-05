using WebArg.CurrencyRates.Cron.DtoModels;

namespace WebArg.CurrencyRates.Cron.Interfaces.Services;

/// <summary>
/// Сервис запросов данных о курсе чешской кроны
/// </summary>
public interface ICronService
{
    /// <summary>
    /// Получить курс чешской кроны за определенную дату
    /// </summary>
    /// <param name="date">Дата</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Курс чешской кроны за запрашиваемую дату</returns>
    Task<ReportDailyDto> DownloadReportAsync(DateOnly date, CancellationToken cancellationToken);
}
