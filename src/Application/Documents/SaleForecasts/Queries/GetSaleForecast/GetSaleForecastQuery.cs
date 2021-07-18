using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Documents;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;

namespace GFCA.Application.Documents.SaleForecasts.Queries.GetSaleForecast
{
    public class GetSaleForecastQuery
        : SaleForecastDto
        , IMapFrom<GetSaleForecastQuery>
        , IRequest<SaleForecastVm>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetSaleForecastQuery, SaleForecastDto>();
            profile.CreateMap<SaleForecastDto, SaleForecast>();
            profile.CreateMap<GetSaleForecastQuery, SaleForecast>();

            profile.CreateMap<SaleForecast, SaleForecastDto>();
            profile.CreateMap<SaleForecast, GetSaleForecastQuery>();
        }
    }
}
