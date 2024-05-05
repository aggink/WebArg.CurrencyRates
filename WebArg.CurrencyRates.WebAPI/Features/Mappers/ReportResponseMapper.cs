using AutoMapper;
using WebArg.CurrencyRates.Logic.DtoModels;
using WebArg.CurrencyRates.WebAPI.Features.DtoModels;

namespace WebArg.CurrencyRates.WebAPI.Features.Mappers;

/// <summary>
/// Mapper Report DtoModels
/// </summary>
public sealed class ReportResponseMapper : Profile
{
    public ReportResponseMapper()
    {
        CreateMap<ReportDto, ReportResponseDto>();
        CreateMap<ReportResponseDto, ReportDto>();
    }
}
