using System.Text.Json.Serialization;

namespace WebArg.CurrencyRates.Web.Common.Middlewares.DtoModels;

/// <summary>
/// Сообщение об ошибке
/// </summary>
public sealed record ErrorResponse
{
    /// <summary>
    /// Код ошибки
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; init; }

    /// <summary>
    /// Сообщение об ошибке
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; init; }

    /// <summary>
    /// Детали ошибки
    /// </summary>
    [JsonPropertyName("details")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public object Details { get; init; }
}
