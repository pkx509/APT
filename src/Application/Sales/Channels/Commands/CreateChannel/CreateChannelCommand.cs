using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Sales;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Sales.Channels.Commands.CreateChannel
{
    public class CreateChannelCommand
        : ChannelDto
        , IMapFrom<ChannelDto>
        , IRequest<int>
    {
        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<CreateChannelCommand, ChannelDto>();
            profile.CreateMap<ChannelDto, Channel>();
            profile.CreateMap<CreateChannelCommand, Channel>();
        }
    }
}
