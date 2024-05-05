using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Quartz;
using Quartz.AspNetCore;
using System.Reflection;
using WebArg.CurrencyRates.Logic.Extensions;
using WebArg.CurrencyRates.Quartz.Jobs;
using WebArg.CurrencyRates.Storage.Database;

namespace WebArg.CurrencyRates.Quartz.Extensions;

/// <summary>
/// Регистрация сервисов в DI
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Максимальное число фоновых потоков
    /// </summary>
    private const int MaxQuartzConcurrency = 10;

    /// <summary>
    /// Регистрация сервисов в DI
    /// </summary>
    /// <param name="services">Коллекция дескрипторов служб</param>
    public static void AddQuartzServices(this IServiceCollection services)
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
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo() { Title = "Quartz", Version = "v1" });
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
    /// Регистрация сервисов Quartz
    /// </summary>
    /// <param name="services">Коллекция дескрипторов служб</param>
    /// <param name="configuration">Набор свойств конфигурации</param>
    public static void RegisterQuartzServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddQuartzServer(opt =>
        {
            opt.AwaitApplicationStarted = true;
            opt.WaitForJobsToComplete = false;
        });

        services.AddQuartz(q =>
        {
            q.SchedulerId = "AUTO";

            q.UseMicrosoftDependencyInjectionJobFactory();
            q.UseDefaultThreadPool(MaxQuartzConcurrency);
            q.MaxBatchSize = MaxQuartzConcurrency;

            q.UsePersistentStore(x =>
            {
                x.UseClustering();
                x.UseSqlServer(configuration.GetDefaultConnectionString());
                x.UseNewtonsoftJsonSerializer();
            });

            q.RegisterJobs(configuration);
        });
    }

    /// <summary>
    /// Регистрация фоновых задач
    /// </summary>
    /// <param name="services">Коллекция дескрипторов служб</param>
    /// <param name="configuration">Набор свойств конфигурации</param>
    private static void RegisterJobs(this IServiceCollectionQuartzConfigurator services, IConfiguration configuration)
    {
        services.ScheduleJob<ReportDailyJob>(
            trigger =>
            {
                trigger.WithIdentity(ReportDailyJob.JobName);
                trigger.WithCronSchedule(
                    configuration.GetReportDailyCronSchedule(),
                    schedule => schedule.WithMisfireHandlingInstructionIgnoreMisfires());
            },
            job =>
            {
                job.DisallowConcurrentExecution();
                job.WithIdentity(ReportDailyJob.JobName);
                job.RequestRecovery();
                job.StoreDurably();
            });
    }
}
