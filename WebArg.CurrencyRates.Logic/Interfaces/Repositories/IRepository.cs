using WebArg.CurrencyRates.Cron.DtoModels;
using WebArg.CurrencyRates.Storage.Database;
using WebArg.CurrencyRates.Storage.Models;

namespace WebArg.CurrencyRates.Logic.Interfaces.Repositories;

/// <summary>
/// CRUD методы для таблицы <see cref="ReportDaily"/>
/// </summary>
public interface IRepository
{
    /// <summary>
    /// Сохранить данные о курсе валюты
    /// </summary>
    /// <param name="dataContext">Контекст базы данных</param>
    /// <param name="report">Курс валюты</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns><see cref="Task"/></returns>
    Task AddReportAsync(DataContext dataContext, ReportDailyDto report, CancellationToken cancellationToken = default);
}
