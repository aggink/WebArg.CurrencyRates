namespace WebArg.CurrencyRates.Cron.DtoModels;

/// <summary>
/// Ежедневный отчет о курсе чешской кроны
/// </summary>
public sealed record ReportDailyDto
{
    /// <summary>
    /// Дата
    /// </summary>
    public DateOnly Date { get; init; }

    /// <summary>
    /// Информация о курсе
    /// </summary>
    public ReportDataDto[] Reports { get; init; }
}
