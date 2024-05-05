using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;
using WebArg.CurrencyRates.Logic.Extensions;
using WebArg.CurrencyRates.Storage.Database;
using WebArg.CurrencyRates.WebAPI.Features.Mappers;

namespace WebArg.CurrencyRates.WebAPI.Extensions;

/// <summary>
/// Регистрация сервисов в DI
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Регистрация сервисов 
    /// </summary>
    /// <param name="services">Коллекция дескрипторов служб</param>
    public static void AddWebServices(this IServiceCollection services)
    {
        services.AddLogicServices();
    }

    /// <summary>
    /// Регистрация Контекста базы данных
    /// </summary>
    /// <param name="services">Коллекция дескрипторов служб</param>
    /// <param name="configuration">Набор свойств конфигурации</param>
    public static void AddDataContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(configuration.GetDefaultConnectionString(), o =>
            {
                o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
            }));
    }

    /// <summary>
    /// Регистрация FluentValidation в DI
    /// </summary>
    /// <param name="services">Коллекция дескрипторов служб</param>
    /// <param name="type">Глобальный тип для поиска валидаторов</param>
    public static void AddFluentValidationSetup(this IServiceCollection services, Type type)
    {
        services.AddFluentValidationAutoValidation();
        services.AddFluentValidationClientsideAdapters();
        services.AddValidatorsFromAssemblyContaining(type);

        ValidatorOptions.Global.DefaultClassLevelCascadeMode = CascadeMode.Stop;
        ValidatorOptions.Global.DefaultRuleLevelCascadeMode = CascadeMode.Stop;
    }

    /// <summary>
    /// Регистрация Swagger
    /// </summary>
    /// <param name="services">Коллекция дескрипторов служб</param>
    public static void AddSwaggerSetup(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo() { Title = "CurrencyRates", Version = "v1" });
            c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

            foreach (FileInfo file in new DirectoryInfo(AppContext.BaseDirectory).GetFiles(
                         Assembly.GetExecutingAssembly().GetName().Name! + ".xml"))
                c.IncludeXmlComments(file.FullName);

            c.EnableAnnotations(enableAnnotationsForInheritance: true,
                enableAnnotationsForPolymorphism: true
            );
        });
    }

    /// <summary>
    /// Регистрация Mapper
    /// </summary>
    /// <param name="services">Коллекция дескрипторов служб</param>
    public static void AddWebMappers(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(ReportResponseMapper));
    }
}
