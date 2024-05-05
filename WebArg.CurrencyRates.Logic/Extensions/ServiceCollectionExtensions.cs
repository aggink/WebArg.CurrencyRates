using Microsoft.Extensions.DependencyInjection;
using WebArg.CurrencyRates.Cron.Extensions;
using WebArg.CurrencyRates.Logic.Interfaces.Repositories;
using WebArg.CurrencyRates.Logic.Interfaces.Services;
using WebArg.CurrencyRates.Logic.Repositories;
using WebArg.CurrencyRates.Logic.Services;

namespace WebArg.CurrencyRates.Logic.Extensions;

/// <summary>
/// Регистрация сервисов в DI
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Регистрация сервисов библиотеки Logic в DI
    /// </summary>
    /// <param name="services">Коллекция дескрипторов служб</param>
    public static void AddLogicServices(this IServiceCollection services)
    {
        services.AddCronServices();

        services.AddSingleton<IRepository, Repository>();
        services.AddSingleton<IReportDailyService, ReportDailyService>();
    }
}
