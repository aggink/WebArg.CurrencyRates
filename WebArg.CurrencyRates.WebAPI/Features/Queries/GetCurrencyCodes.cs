using MediatR;
using Microsoft.EntityFrameworkCore;
using WebArg.CurrencyRates.Storage.Database;

namespace WebArg.CurrencyRates.WebAPI.Features.Queries;

/// <summary>
/// Получить коды валют
/// </summary>
public sealed class GetCurrencyCodesQuery : IRequest<string[]>
{

}

public sealed class GetCurrencyCodesQueryHandler : IRequestHandler<GetCurrencyCodesQuery, string[]>
{
    private readonly DataContext _dataContext;

    public GetCurrencyCodesQueryHandler(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<string[]> Handle(GetCurrencyCodesQuery request, CancellationToken cancellationToken)
    {
        var codes = _dataContext.Reports
            .AsNoTracking()
            .GroupBy(x => x.Code)
            .Select(x => x.Key)
            .OrderBy(x => x)
            .ToArray();

        return codes;
    }
}
