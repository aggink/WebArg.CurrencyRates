namespace WebArg.CurrencyRates.Cron.DtoModels;

/// <summary>
/// Информация о курсе
/// </summary>
public sealed record ReportDataDto
{
    /// <summary>
    /// Страна
    /// </summary>
    public string Country { get; init; }

    /// <summary>
    /// Валюта
    /// </summary>
    public string Currency { get; init; }

    /// <summary>
    /// Номинал
    /// </summary>
    public int Amount { get; init; }

    /// <summary>
    /// Код валюты
    /// </summary>
    public string Code { get; init; }

    /// <summary>
    /// Курс
    /// </summary>
    public decimal Rate { get; init; }
}
