namespace WebArg.CurrencyRates.Logic.DtoModels;

/// <summary>
/// Отчет о курсе валюты за период
/// </summary>
public sealed record ReportDto
{
    /// <summary>
    /// Начало периода
    /// </summary>
    public DateOnly DateFrom { get; init; }

    /// <summary>
    /// Конец периода
    /// </summary>
    public DateOnly DateTo { get; init; }

    /// <summary>
    /// Код валюты
    /// </summary>
    public string Code { get; init; }

    /// <summary>
    /// Среднее значение
    /// </summary>
    public decimal Avg { get; init; }

    /// <summary>
    /// Максимальное значение
    /// </summary>
    public decimal Max { get; init; }

    /// <summary>
    /// Минимальное значение
    /// </summary>
    public decimal Min { get; init; }
}
