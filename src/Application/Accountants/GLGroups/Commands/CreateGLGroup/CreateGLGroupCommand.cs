using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Accountants;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Accountants.GLGroups.Commands.CreateGLGroup
{
    public class CreateGLGroupCommand
    : GLGroupDto
        , IMapFrom<GLGroupDto>
        , IRequest<int>
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<CreateGLGroupCommand, GLAccountDto>();
            profile.CreateMap<GLAccountDto, GLGroup>();
            profile.CreateMap<CreateGLGroupCommand, GLAccount>();
        }

    }
}
