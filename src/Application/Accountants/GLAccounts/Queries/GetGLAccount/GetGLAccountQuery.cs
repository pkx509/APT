using System;
using System.Linq.Expressions;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Common;
using GFCA.Domain.Entities.Accountants;
using GFCA.Shared.Models.Common;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;

namespace GFCA.Application.Accountants.GLAccounts.Queries.GetGLAccount
{
    public class GetGLAccountQuery
        : GLAccountDto
        , IMapFrom<GetGLAccountQuery>
        , IRequest<GLAccountVm>
    {
        public void Mapping(Profile profile)
        {

            //profile.CreateMap<GLAccount, GLAccountDto>().Include<GLAccount, GetGLAccountQuery>();

            /*
            profile
                .CreateMap<AuditableEntity, AuditableDtoBase>()
                .Include<GLAccount, GLAccountDto>()
                ;
            */
            /*
            profile
                .CreateMap<GLAccount, GetGLAccountQuery>()
                .ForMember(d => d.AccountId, o => o.MapFrom(s => s.AccountId))
                .ForMember(d => d.GLGroup, o => o.MapFrom(s => s.GLGroup))
                .ForMember(d => d.GLGroupName, o => o.MapFrom(s => s.GLGroup.GroupName))
                .ForMember(d => d.GLGroupId, o => o.MapFrom(s => s.GLGroup.GroupId))
                .ForMember(d => d.GLCode, o => o.MapFrom(s => s.GLCode))
                .ForMember(d => d.GLName, o => o.MapFrom(s => s.GLName))
                .ForMember(d => d.Purpose, o => o.MapFrom(s => s.Purpose))
                .ForMember(d => d.Remark, o => o.MapFrom(s => s.Remark))
                ;
            */
            //profile.CreateMap<GetGLAccountQuery, GLAccountDto>();
            //profile.CreateMap<GLAccountDto, GLAccount>();
            profile.CreateMap<GetGLAccountQuery, GLAccount>()
                .ForMember(d => d.AccountId, o => o.MapFrom(s => s.AccountId))
                //.ForMember(d => d.GLGroupId, o => o.MapFrom(s => s.GLGroup.GroupId))
                //.ForMember(d => d.GLGroup, o => o.MapFrom(s => s.GLGroup.GroupId))
                .ForMember(d => d.GLCode, o => o.MapFrom(s => s.GLCode))
                .ForMember(d => d.GLName, o => o.MapFrom(s => s.GLName))
                .ForMember(d => d.Purpose, o => o.MapFrom(s => s.Purpose))
                .ForMember(d => d.Remark, o => o.MapFrom(s => s.Remark))
                ;

            profile.CreateMap<GLAccount, GLAccountDto>()
                .ForMember(d => d.AccountId, o => o.MapFrom(s => s.AccountId))
                .ForMember(d => d.GLGroupId, o => o.MapFrom(s => s.GLGroup.GroupId))
                //.ForMember(d => d.GLGroupName, o => o.MapFrom(s => s.GLGroup.GroupName))
                .ForMember(d => d.GLCode, o => o.MapFrom(s => s.GLCode))
                .ForMember(d => d.GLName, o => o.MapFrom(s => s.GLName))
                .ForMember(d => d.Purpose, o => o.MapFrom(s => s.Purpose))
                .ForMember(d => d.Remark, o => o.MapFrom(s => s.Remark))
                .ForMember(d => d.GLGroupName, conf => {
                    //conf.ExplicitExpansion();
                    conf.MapAtRuntime();
                    conf.MapFrom(_ => _.GLGroup.GroupName);
                })
                ;

            /*
            profile.CreateMap<GLAccount, GetGLAccountQuery>()
                .ForMember(d => d.AccountId, o => o.MapFrom(s => s.AccountId))
                .ForMember(d => d.GLGroup, o => o.MapFrom(s => s.GLGroup))
                .ForMember(d => d.GLGroupName, o => o.MapFrom(s => s.GLGroup.GroupName))
                .ForMember(d => d.GLGroupId, o => o.MapFrom(s => s.GLGroup.GroupId))
                .ForMember(d => d.GLCode, o => o.MapFrom(s => s.GLCode))
                .ForMember(d => d.GLName, o => o.MapFrom(s => s.GLName))
                .ForMember(d => d.Purpose, o => o.MapFrom(s => s.Purpose))
                .ForMember(d => d.Remark, o => o.MapFrom(s => s.Remark))
                ;
            */
            profile.CreateMap<GLAccount, GetGLAccountQuery>()
                .ForMember(d => d.AccountId, o => o.MapFrom(s => s.AccountId))
                //.ForMember(d => d.GLGroup, o => o.MapFrom(s => s.GLGroup))
                .ForMember(d => d.GLGroupId, o => o.MapFrom(s => s.GLGroup.GroupId))
                //.ForMember(d => d.GLGroupName, o => o.MapFrom(s => s.GLGroup.GroupName))
                .ForMember(d => d.GLCode, o => o.MapFrom(s => s.GLCode))
                .ForMember(d => d.GLName, o => o.MapFrom(s => s.GLName))
                .ForMember(d => d.Purpose, o => o.MapFrom(s => s.Purpose))
                .ForMember(d => d.Remark, o => o.MapFrom(s => s.Remark))
                .ForMember(d => d.GLGroupName, conf => {
                    conf.MapAtRuntime();
                    //conf.ExplicitExpansion();
                    conf.MapFrom(_ => _.GLGroup.GroupName);
                })
                ;
        }
    }

}
