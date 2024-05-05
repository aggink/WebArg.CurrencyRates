using WebArg.CurrencyRates.Logic.DtoModels;
using WebArg.CurrencyRates.Storage.Database;
using WebArg.CurrencyRates.Storage.Models;

namespace WebArg.CurrencyRates.Logic.Interfaces.Services;

/// <summary>
/// Сервис обработки данные для <see cref="ReportDaily"/>
/// </summary>
public interface IReportDailyService
{
    /// <summary>
    /// Получить данные о курсе валют за период
    /// </summary>
    /// <param name="dataContext">Контекст базы данных</param>
    /// <param name="start">Начала периода</param>
    /// <param name="end">Конец периода</param>
    /// <param name="codes">Коды валют</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Данные о курсе валют за период</returns>
    Task<ReportDto[]> GetReportAsync(DataContext dataContext, DateOnly start, DateOnly end, string[] codes, CancellationToken cancellationToken = default);

    /// <summary>
    /// Сохранить данные о курсе валют
    /// </summary>
    /// <param name="dataContext">Контекст базы данных</param>
    /// <param name="start">Начало периода</param>
    /// <param name="end">Конец периода</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns><see cref="Task"/></returns>
    Task AddReportAsync(DataContext dataContext, DateOnly start, DateOnly end, CancellationToken cancellationToken = default);
}
