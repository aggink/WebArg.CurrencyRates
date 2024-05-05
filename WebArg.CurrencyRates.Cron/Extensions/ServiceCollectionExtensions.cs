using Microsoft.Extensions.DependencyInjection;
using Refit;
using WebArg.CurrencyRates.Cron.Interfaces.Services;
using WebArg.CurrencyRates.Cron.Refit;
using WebArg.CurrencyRates.Cron.Services;

namespace WebArg.CurrencyRates.Cron.Extensions;

/// <summary>
/// Регистрация сервисов в DI
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Регистрация сервисов библиотеки Cron в DI
    /// </summary>
    /// <param name="services">Коллекция дескрипторов служб</param>
    public static void AddCronServices(this IServiceCollection services)
    {
        services.AddCronRefitServices();
        services.AddSingleton<ICronService, CronService>();
    }

    /// <summary>
    /// Регистрация Refit Cron API
    /// </summary>
    /// <param name="services">Коллекция дескрипторов служб</param>
    private static void AddCronRefitServices(this IServiceCollection services)
    {
        services
            .AddRefitClient<IApiCronService>(_ => new RefitSettings()
            {
                CollectionFormat = CollectionFormat.Multi
            })
            .ConfigureHttpClient(client =>
            {
                client.BaseAddress = new Uri("https://www.cnb.cz");
            });
    }
}
