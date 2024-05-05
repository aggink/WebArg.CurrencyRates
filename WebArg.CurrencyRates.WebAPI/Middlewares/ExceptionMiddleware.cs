using System.Net;
using WebArg.CurrencyRates.Logic.Exceptions;
using WebArg.CurrencyRates.Web.Common.Middlewares;
using WebArg.CurrencyRates.Web.Common.Middlewares.DtoModels;
using WebArg.CurrencyRates.WebAPI.Exceptions;

namespace WebArg.CurrencyRates.WebAPI.Middlewares;

/// <summary>
/// Обработчик ошибок
/// </summary>
public sealed class ExceptionMiddleware : ExceptionBaseMiddleware
{
    public ExceptionMiddleware(
        RequestDelegate next,
        ILogger<ExceptionMiddleware> logger)
        : base(next, logger)
    {

    }

    protected override ErrorResponseDto GetErrorResponse(HttpContext context, Exception ex)
    {
        switch (ex)
        {
            case ArgumentQueryException queryException:
                return new ErrorResponseDto
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Response = new ErrorResponse
                    {
                        Code = queryException.HResult.ToString(),
                        Message = queryException.Message
                    }
                };
            case LogicException cryptoException:
                return new ErrorResponseDto
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Response = new ErrorResponse
                    {
                        Code = cryptoException.HResult.ToString(),
                        Message = cryptoException.Message
                    }
                };
            default:
                return null;
        }
    }
}
