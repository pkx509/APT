using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Sales;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;

namespace GFCA.Application.Sales.Channels.Queries.GetChannel
{
    public class GetChannelQuery
        : ChannelDto
        , IMapFrom<GetChannelQuery>
        , IRequest<ChannelVm>
    {

        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetChannelQuery, ChannelDto>();
            profile.CreateMap<ChannelDto, Channel>();
            profile.CreateMap<GetChannelQuery, Channel>();

            profile.CreateMap<Channel, ChannelDto>();
            profile.CreateMap<Channel, GetChannelQuery>();
        }

    }
}
