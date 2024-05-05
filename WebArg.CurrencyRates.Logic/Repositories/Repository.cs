using WebArg.CurrencyRates.Cron.DtoModels;
using WebArg.CurrencyRates.Logic.Interfaces.Repositories;
using WebArg.CurrencyRates.Storage.Database;
using WebArg.CurrencyRates.Storage.Models;

namespace WebArg.CurrencyRates.Logic.Repositories;

public sealed class Repository : IRepository
{
    public async Task AddReportAsync(DataContext dataContext, ReportDailyDto report, CancellationToken cancellationToken = default)
    {
        if (!dataContext.Reports.Any(x => x.Date == report.Date))
        {
            var models = MapFromReportDailyDto(report);
            await dataContext.Reports.AddRangeAsync(models);
        }
    }

    private static ReportDaily[] MapFromReportDailyDto(ReportDailyDto reportDaily)
    {
        var list = new List<ReportDaily>();

        foreach (var report in reportDaily.Reports)
        {
            var model = new ReportDaily
            {
                IsnReportDaily = Guid.NewGuid(),
                Date = reportDaily.Date,
                Country = report.Country,
                Currency = report.Currency,
                Code = report.Code,
                Rate = report.Rate
            };

            list.Add(model);
        }

        return list.ToArray();
    }
}
