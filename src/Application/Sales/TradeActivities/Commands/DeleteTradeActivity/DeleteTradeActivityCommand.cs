using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Sales;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Sales.TradeActivities.Commands.DeleteTradeActivity
{
    public class DeleteTradeActivityCommand
        : TradeActivityDto
        , IMapFrom<TradeActivityDto>
        , IRequest
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<DeleteTradeActivityCommand, TradeActivityDto>();
            profile.CreateMap<TradeActivityDto, TradeActivity>();
            profile.CreateMap<DeleteTradeActivityCommand, TradeActivity>();
        }

    }
}
