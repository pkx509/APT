using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Sales;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Sales.TradeActivities.Commands.CreateTradeActivity
{
    public class CreateTradeActivityCommand : TradeActivityDto
        , IMapFrom<TradeActivityDto>
        , IRequest<int>
    {
        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<CreateTradeActivityCommand, ChannelDto>();
            profile.CreateMap<TradeActivityDto, TradeActivity>();
            profile.CreateMap<CreateTradeActivityCommand, TradeActivity>();
        }
    }
}
