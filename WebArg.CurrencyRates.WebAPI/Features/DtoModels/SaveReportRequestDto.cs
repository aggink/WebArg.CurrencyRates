using System.ComponentModel.DataAnnotations;

namespace WebArg.CurrencyRates.WebAPI.Features.DtoModels;

/// <summary>
/// Данные формирования отчета
/// </summary>
public sealed record SaveReportRequestDto
{
    /// <summary>
    /// Дата начала периода
    /// </summary>
    [Required]
    public DateOnly StartDate { get; init; }

    /// <summary>
    /// Дата конца периода
    /// </summary>
    [Required]
    public DateOnly EndDate { get; init; }
}
