using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Sales;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Sales.Channels.Commands.DeleteChannel
{
    public class DeleteChannelCommand
        : ChannelDto
        , IMapFrom<ChannelDto>
        , IRequest
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<DeleteChannelCommand, ChannelDto>();
            profile.CreateMap<ChannelDto, Channel>();
            profile.CreateMap<DeleteChannelCommand, Channel>();
        }

    }
}
