using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Accountants;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Accountants.GLAccounts.Commands.CreateGLAccount
{
    public class CreateGLAccountCommand
        : GLAccountDto
        , IMapFrom<GLAccountDto>
        , IRequest<int>
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<CreateGLAccountCommand, GLAccountDto>();
            profile.CreateMap<GLAccountDto, GLAccount>();
            profile.CreateMap<CreateGLAccountCommand, GLAccount>();
            profile.CreateMap<GLAccount, GLAccountDto>()
                .ForMember(d => d.AccountId, o => o.MapFrom(s => s.AccountId))
                .ForMember(d => d.GLGroupId, o => o.MapFrom(s => s.GLGroup.GroupId))
                .ForMember(d => d.GLGroupName, o => o.MapFrom(s => s.GLGroup.GroupName))
                .ForMember(d => d.GLCode, o => o.MapFrom(s => s.GLCode))
                .ForMember(d => d.GLName, o => o.MapFrom(s => s.GLName))
                .ForMember(d => d.Purpose, o => o.MapFrom(s => s.Purpose))
                .ForMember(d => d.Remark, o => o.MapFrom(s => s.Remark))
                ;
            profile.CreateMap<GLAccount, CreateGLAccountCommand>()
                .ForMember(d => d.AccountId, o => o.MapFrom(s => s.AccountId))
                .ForMember(d => d.GLGroupId, o => o.MapFrom(s => s.GLGroup.GroupId))
                .ForMember(d => d.GLGroupName, o => o.MapFrom(s => s.GLGroup.GroupName))
                .ForMember(d => d.GLCode, o => o.MapFrom(s => s.GLCode))
                .ForMember(d => d.GLName, o => o.MapFrom(s => s.GLName))
                .ForMember(d => d.Purpose, o => o.MapFrom(s => s.Purpose))
                .ForMember(d => d.Remark, o => o.MapFrom(s => s.Remark))
                ;
        }

    }
}
