using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WebArg.CurrencyRates.Logic.Interfaces.Services;
using WebArg.CurrencyRates.Storage.Database;
using WebArg.CurrencyRates.WebAPI.Features.DtoModels;

namespace WebArg.CurrencyRates.WebAPI.Features.Queries;

/// <summary>
/// Получить отчет о курсах валют за период
/// </summary>
public sealed class GetReportQuery : IRequest<ReportResponseDto[]>
{
    /// <summary>
    /// Дата начала периода
    /// </summary>
    [Required]
    [FromQuery]
    public DateOnly StartDate { get; init; }

    /// <summary>
    /// Дата конца периода
    /// </summary>
    [Required]
    [FromQuery]
    public DateOnly EndDate { get; init; }

    /// <summary>
    /// Коды валют
    /// </summary>
    [Required]
    [FromBody]
    public string[] Codes { get; init; }
}

public sealed class GetReportQueryValidator : AbstractValidator<GetReportQuery>
{
    public GetReportQueryValidator()
    {
        RuleFor(x => x.StartDate)
            .NotEmpty();

        RuleFor(x => x.EndDate)
            .NotEmpty();

        RuleFor(x => x.Codes)
            .NotEmpty();

        RuleFor(x => x)
            .Must(x => x.StartDate < x.EndDate)
                .WithMessage("Дата начала периода должна быть раньше даты конца периода");
    }
}

public sealed class GetReportQueryHandler : IRequestHandler<GetReportQuery, ReportResponseDto[]>
{
    private readonly IMapper _mapper;
    private readonly DataContext _dataContext;
    private readonly IReportDailyService _reportDailyService;

    public GetReportQueryHandler(
        IMapper mapper,
        DataContext dataContext,
        IReportDailyService reportDailyService)
    {
        _mapper = mapper;
        _dataContext = dataContext;
        _reportDailyService = reportDailyService;
    }

    public async Task<ReportResponseDto[]> Handle(GetReportQuery request, CancellationToken cancellationToken)
    {
        var codes = request.Codes
            .Where(x => !string.IsNullOrEmpty(x))
            .ToArray();

        var result = await _reportDailyService.GetReportAsync(_dataContext, request.StartDate, request.EndDate, codes, cancellationToken);
        var reports = _mapper.Map<ReportResponseDto[]>(result);

        return reports;
    }
}
