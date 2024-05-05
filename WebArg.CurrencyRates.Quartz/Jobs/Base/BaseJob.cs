using Quartz;

namespace WebArg.CurrencyRates.Quartz.Jobs.Base;

/// <summary>
/// Базовый класс фоновой задачи
/// </summary>
public abstract class BaseJob : IJob
{
    private readonly string _jobName;
    protected readonly ILogger _logger;
    protected readonly IServiceProvider _serviceProvider;

    protected BaseJob(
        ILogger logger,
        IServiceProvider serviceProvider)
    {
        _jobName = GetType().Name;

        _logger = logger;
        _serviceProvider = serviceProvider;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        var plannedStartTime = context.ScheduledFireTimeUtc;
        var actualFireTime = context.FireTimeUtc;

        JobContext.SetTrigger(context.Trigger);

        try
        {
            var delay = actualFireTime - plannedStartTime;

            // for case when fire time earlier than planned
            if (delay is { TotalMilliseconds: < 0 })
                delay = TimeSpan.Zero;

            _logger.LogInformation("Задача {JobName} запущена", _jobName);

            await DoWork(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "В ходе выполнения задачи {JobName} произошла ошибка", _jobName);
        }
        finally
        {
            _logger.LogInformation("Задача {JobName} завершена", _jobName);
        }
    }

    protected abstract Task DoWork(IJobExecutionContext context);
}
