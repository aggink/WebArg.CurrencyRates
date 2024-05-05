using System.Net;

namespace WebArg.CurrencyRates.Web.Common.Middlewares.DtoModels;

/// <summary>
/// Информация об ошибке
/// </summary>
public sealed record ErrorResponseDto
{
    /// <summary>
    /// HTTP-статус
    /// </summary>
    public HttpStatusCode StatusCode { get; init; }

    /// <summary>
    /// Сообщение об ошибке
    /// </summary>
    public ErrorResponse Response { get; init; }
}
