using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WebArg.CurrencyRates.Logic.Interfaces.Services;
using WebArg.CurrencyRates.Storage.Database;
using WebArg.CurrencyRates.WebAPI.Features.DtoModels;

namespace WebArg.CurrencyRates.WebAPI.Features.Commands;

/// <summary>
/// Запросить отчет за период
/// </summary>
public sealed class SaveReportCommand : IRequest
{
    /// <summary>
    /// Данные для формирования отчета
    /// </summary>
    [Required]
    [FromBody]
    public SaveReportRequestDto Report { get; init; }
}

public sealed class SaveReportCommandValidator : AbstractValidator<SaveReportCommand>
{
    public SaveReportCommandValidator(IValidator<SaveReportRequestDto> validator)
    {
        RuleFor(x => x.Report)
            .NotNull()
            .SetValidator(validator)
            .OverridePropertyName(string.Empty);
    }
}

public sealed class SaveReportRequestDtoValidator : AbstractValidator<SaveReportRequestDto>
{
    public SaveReportRequestDtoValidator()
    {
        RuleFor(x => x.StartDate)
            .NotEmpty();

        RuleFor(x => x.EndDate)
            .NotEmpty();

        RuleFor(x => x)
            .Must(x => x.StartDate < x.EndDate)
                .WithMessage("Дата начала периода должна быть раньше даты конца периода");
    }
}

public sealed class SaveReportCommandHandler : IRequestHandler<SaveReportCommand>
{
    private readonly DataContext _dataContext;
    private readonly IReportDailyService _reportDailyService;

    public SaveReportCommandHandler(DataContext dataContext, IReportDailyService reportDailyService)
    {
        _dataContext = dataContext;
        _reportDailyService = reportDailyService;
    }

    public async Task Handle(SaveReportCommand request, CancellationToken cancellationToken)
    {
        await _reportDailyService.DownloadReportAsync(_dataContext, request.Report.StartDate, request.Report.EndDate, cancellationToken);
        await _dataContext.SaveChangesAsync(cancellationToken);
    }
}