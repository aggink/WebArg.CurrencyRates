using WebArg.CurrencyRates.Quartz.Exceptions;

namespace WebArg.CurrencyRates.Quartz.Extensions;

/// <summary>
/// Получение данных из файла настроек
/// </summary>
public static class ConfigurationExtensions
{
    /// <summary>
    /// Получить расписание для фоновой задачи обновления курса валют
    /// </summary>
    /// <param name="configuration">Набор свойств конфигурации</param>
    /// <returns>Расписание запуска фоновой задачи обновления курса валют</returns>
    /// <exception cref="QuartzException">Данные не найдены</exception>
    public static string GetReportDailyCronSchedule(this IConfiguration configuration)
    {
        var schedule = configuration.GetValue<string>("Quartz:Jobs:ReportDailyCronSchedule");
        return !string.IsNullOrEmpty(schedule)
            ? schedule
            : throw new QuartzException("Quartz:Jobs:ReportDailyCronSchedule не найден или пуст");
    }
}
