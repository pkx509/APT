using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Accountants;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Accountants.GLGroups.Commands.UpdateGLGroup
{
    public class UpdateGLGroupCommand
        : GLGroupDto
        , IMapFrom<GLGroupDto>
        , IRequest
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<UpdateGLGroupCommand, GLGroupDto>();
            profile.CreateMap<GLGroupDto, GLGroup>();
            profile.CreateMap<UpdateGLGroupCommand, GLGroup>();
        }

    }
}
