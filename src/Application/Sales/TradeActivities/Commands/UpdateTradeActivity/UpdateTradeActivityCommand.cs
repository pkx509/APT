using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Sales;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Sales.TradeActivities.Commands.UpdateTradeActivity
{
    public class UpdateTradeActivityCommand
        : TradeActivityDto
        , IMapFrom<TradeActivityDto>
        , IRequest
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<UpdateTradeActivityCommand, TradeActivityDto>();
            profile.CreateMap<TradeActivityDto, TradeActivity>();
            profile.CreateMap<UpdateTradeActivityCommand, TradeActivity>();
        }

    }
}
