using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebArg.CurrencyRates.Storage.Models;

/// <summary>
/// Данные о валюте
/// </summary>
public sealed class ReportDaily
{
    /// <summary>
    /// Идентификатор записи
    /// </summary>
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid IsnReportDaily { get; set; }

    /// <summary>
    /// Дата текущего курса
    /// </summary>
    [Required]
    public DateOnly Date { get; set; }

    /// <summary>
    /// Страна
    /// </summary>
    [Required]
    public string Country { get; set; }

    /// <summary>
    /// Валюта
    /// </summary>
    [Required]
    public string Currency { get; set; }

    /// <summary>
    /// Код валюты
    /// </summary>
    [Required]
    public string Code { get; set; }

    /// <summary>
    /// Курс валюты
    /// </summary>
    [Required]
    public decimal Rate { get; set; }
}
