using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Accountants;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Accountants.GLGroups.Commands.DeleteGLGroup
{
    public class DeleteGLGroupCommand
    : GLGroupDto
        , IMapFrom<GLGroupDto>
        , IRequest
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<DeleteGLGroupCommand, GLAccountDto>();
            profile.CreateMap<GLAccountDto, GLGroup>();
            profile.CreateMap<DeleteGLGroupCommand, GLGroup>();
        }

    }
}
