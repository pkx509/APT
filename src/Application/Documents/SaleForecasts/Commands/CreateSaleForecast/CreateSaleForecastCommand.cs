using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Documents;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Documents.SaleForecasts.Commands.CreateSaleForecast
{
    public class CreateSaleForecastCommand : SaleForecastDto
        , IMapFrom<CreateSaleForecastCommand>
    {
        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<CreateSaleForecastCommand, SaleForecastDto>();
            profile.CreateMap<SaleForecastDto, SaleForecast>();
            profile.CreateMap<CreateSaleForecastCommand, SaleForecast>();
        }

    }
}
