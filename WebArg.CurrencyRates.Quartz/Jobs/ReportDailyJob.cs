using Quartz;
using WebArg.CurrencyRates.Logic.Interfaces.Services;
using WebArg.CurrencyRates.Quartz.Jobs.Base;
using WebArg.CurrencyRates.Storage.Database;

namespace WebArg.CurrencyRates.Quartz.Jobs;

/// <summary>
/// Фоновая задача обновления курса валюты чешской кроны
/// </summary>
public sealed class ReportDailyJob : BaseJob
{
    public const string JobName = "ReportDaily";
    private readonly IReportDailyService _reportDailyService;

    public ReportDailyJob(
        ILogger<ReportDailyJob> logger,
        IServiceProvider serviceProvider,
        IReportDailyService reportDailyService)
        : base(logger, serviceProvider)
    {
        _reportDailyService = reportDailyService;
    }

    protected override async Task DoWork(IJobExecutionContext context)
    {
        using var scope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope();
        using var dataContext = scope.ServiceProvider.GetRequiredService<DataContext>();

        var date = DateOnly.FromDateTime(DateTime.Now);
        await _reportDailyService.DownloadReportAsync(dataContext, date, date, context.CancellationToken);

        await dataContext.SaveChangesAsync();
    }
}
