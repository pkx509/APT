using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Documents;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Documents.SaleForecasts.Commands.UpdateSaleForecast
{
    public class UpdateSaleForecastCommand
        : SaleForecastDto
        , IMapFrom<UpdateSaleForecastCommand>
    {
        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<UpdateSaleForecastCommand, SaleForecastDto>();
            profile.CreateMap<SaleForecastDto, SaleForecast>();
            profile.CreateMap<UpdateSaleForecastCommand, SaleForecast>();
        }
    }
}
