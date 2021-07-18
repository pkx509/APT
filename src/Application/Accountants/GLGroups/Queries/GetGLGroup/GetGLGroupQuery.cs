using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Accountants;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;

namespace GFCA.Application.Accountants.GLGroups.Queries.GetGLGroup
{
    public class GetGLGroupQuery : GLGroupDto
        , IMapFrom<GetGLGroupQuery>
        , IRequest<GLGroupVm>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetGLGroupQuery, GLGroupDto>();
            profile.CreateMap<GLGroupDto, GLGroup>();
            profile.CreateMap<GetGLGroupQuery, GLGroup>();

            profile.CreateMap<GLGroup, GLGroupDto>();
            profile.CreateMap<GLGroup, GetGLGroupQuery>();
        }
    }
}
