using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WebArg.CurrencyRates.Storage.Database;
using WebArg.CurrencyRates.WebAPI.Exceptions;
using WebArg.CurrencyRates.WebAPI.Features.DtoModels;

namespace WebArg.CurrencyRates.WebAPI.Features.Queries;

/// <summary>
/// Получить код валюты за текущее число
/// </summary>
public sealed class GetCurrencyRateTodayQuery : IRequest<CurrencyRate>
{
    /// <summary>
    /// Код валюты
    /// </summary>
    [Required]
    [FromQuery]
    public string Code { get; set; }
}

public sealed class GetCurrencyRateTodayQueryValidator : AbstractValidator<GetCurrencyRateTodayQuery>
{
    public GetCurrencyRateTodayQueryValidator()
    {
        RuleFor(x => x.Code)
            .NotEmpty();
    }
}

public sealed class GetCurrencyRateTodayQueryHandler : IRequestHandler<GetCurrencyRateTodayQuery, CurrencyRate>
{
    private readonly DataContext _dataContext;

    public GetCurrencyRateTodayQueryHandler(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<CurrencyRate> Handle(GetCurrencyRateTodayQuery request, CancellationToken cancellationToken)
    {
        var today = DateTime.UtcNow;
        var date = new DateOnly(today.Year, today.Month, today.Day);

        if (!_dataContext.Reports.Any(x => x.Code == request.Code))
            throw new ArgumentQueryException($"Данные о курсе валюты с кодом {request.Code} не найдены");

        var rate = _dataContext.Reports.FirstOrDefault(x => x.Code == request.Code && x.Date == date)
            ?? throw new ArgumentQueryException("Данные за текущий день не найдены");

        var rateDto = new CurrencyRate
        {
            Date = rate.Date,
            Code = rate.Code,
            Value = rate.Rate
        };

        return rateDto;
    }
}
