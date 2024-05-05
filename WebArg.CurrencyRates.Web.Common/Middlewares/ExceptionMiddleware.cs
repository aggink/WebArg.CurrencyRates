using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Net;
using WebArg.CurrencyRates.Web.Common.Middlewares.DtoModels;

namespace WebArg.CurrencyRates.Web.Common.Middlewares;

/// <summary>
/// Обработчик ошибок
/// </summary>
public abstract class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger _logger;

    public ExceptionMiddleware(
        RequestDelegate next,
        ILogger logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            var error = GetErrorResponseBase(context, ex);

            context.Response.StatusCode = (int)error.StatusCode;
            await context.Response.WriteAsJsonAsync(error.Response);

            _logger.LogError(ex, "Произошла ошибка при выполнении запроса. Описание запроса: {Request}", context.Request);
        }
    }

    /// <summary>
    /// Получить сообщение об ошибке
    /// </summary>
    /// <param name="context">HTTP-контекст</param>
    /// <param name="ex">Ошибка</param>
    /// <returns>Сообщение об ошибке</returns>
    protected abstract ErrorResponseDto GetErrorResponse(HttpContext context, Exception ex);

    /// <summary>
    /// Получить описание ошибки
    /// </summary>
    /// <param name="context">HttpContext</param>
    /// <param name="ex">Ошибка</param>
    /// <returns>Описание ошибки</returns>
    private ErrorResponseDto GetErrorResponseBase(HttpContext context, Exception ex)
    {
        if (ex is OperationCanceledException canceledException && context.RequestAborted.IsCancellationRequested)
        {
            return new ErrorResponseDto
            {
                StatusCode = HttpStatusCode.BadRequest,
                Response = new ErrorResponse
                {
                    Code = canceledException.HResult.ToString(),
                    Message = "Запрос был отменен"
                }
            };
        }

        var response = GetErrorResponse(context, ex);
        if (response == null)
        {
            return new ErrorResponseDto
            {
                StatusCode = HttpStatusCode.InternalServerError,
                Response = new ErrorResponse
                {
                    Code = ex.HResult.ToString(),
                    Message = "Что-то пошло не так. Пожалуйста, повторите попытку позже"
                }
            };
        }

        return response;
    }
}
