using Refit;

namespace WebArg.CurrencyRates.Cron.Refit;

/// <summary>
/// Запросы к API Чешского банка
/// </summary>
public interface IApiCronService
{
    /// <summary>
    /// Получить курс чешской кроны за определенную дату
    /// </summary>
    /// <param name="date">Дата</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Курс чешской кроны</returns>
    [Get("/en/financial-markets/foreign-exchange-market/central-bank-exchange-rate-fixing/central-bank-exchange-rate-fixing/daily.txt")]
    Task<IApiResponse<string>> GetDailyReport([Query] string date, CancellationToken cancellationToken = default);
}
