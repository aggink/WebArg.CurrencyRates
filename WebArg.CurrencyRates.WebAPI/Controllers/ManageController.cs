using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebArg.CurrencyRates.Web.Common.DataAnnotations;
using WebArg.CurrencyRates.WebAPI.Features.Commands;
using WebArg.CurrencyRates.WebAPI.Features.DtoModels;
using WebArg.CurrencyRates.WebAPI.Features.Queries;

namespace WebArg.CurrencyRates.WebAPI.Controllers;

/// <summary>
/// Курс валюты чешской кроны
/// </summary>
[ApiController]
[Route("[controller]")]
[Produces("application/json")]
[ValidateUsingFluentValidation]
public class ManageController : Controller
{
    private readonly IMediator _mediator;

    public ManageController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Получить отчет о курсах валют за период
    /// </summary>
    /// <param name="query">Dto параметр</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Отчет о курсах валют за период</returns>
    [HttpPost(nameof(GetReport), Name = nameof(GetReport))]
    public async Task<ActionResult<ReportResponseDto[]>> GetReport(GetReportQuery query, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(query, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Запросить отчет за период
    /// </summary>
    /// <param name="command">Dto параметр</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns></returns>
    [HttpPost(nameof(SaveReport), Name = nameof(SaveReport))]
    public async Task<ActionResult> SaveReport(SaveReportCommand command, CancellationToken cancellationToken)
    {
        await _mediator.Send(command, cancellationToken);
        return Ok();
    }

    /// <summary>
    /// Получить коды валют
    /// </summary>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Коды валют</returns>
    [HttpGet(nameof(GetCurrencyCodes), Name = nameof(GetCurrencyCodes))]
    public async Task<ActionResult<string[]>> GetCurrencyCodes(CancellationToken cancellationToken)
    {
        var codes = await _mediator.Send(new GetCurrencyCodesQuery(), cancellationToken);
        return Ok(codes);
    }

    /// <summary>
    /// Получить курс валюты за текущий день
    /// </summary>
    /// <param name="query">Dto параметр</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Курс валюты за текущий день</returns>
    [HttpGet(nameof(GetCurrencyRateToday), Name = nameof(GetCurrencyRateToday))]
    public async Task<ActionResult<CurrencyRate>> GetCurrencyRateToday(GetCurrencyRateTodayQuery query, CancellationToken cancellationToken)
    {
        var rate = await _mediator.Send(query, cancellationToken);
        return Ok(rate);
    }
}
