using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Organizations;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;

namespace GFCA.Application.Organizations.Companies.Queries.GetCompany
{
    public class GetCompanyQuery
        : CompanyDto
        , IMapFrom<GetCompanyQuery>
        , IRequest<CompanyVm>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetCompanyQuery, CompanyDto>();
            profile.CreateMap<CompanyDto, Company>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.CompanyId))
                .ForMember(d => d.Code, opt => opt.MapFrom(s => s.CompanyCode))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.CompanyName));
            profile.CreateMap<GetCompanyQuery, Company>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.CompanyId))
                .ForMember(d => d.Code, opt => opt.MapFrom(s => s.CompanyCode))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.CompanyName));

            profile.CreateMap<Company, CompanyDto>()
                .ForMember(d => d.CompanyId, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.CompanyCode, opt => opt.MapFrom(s => s.Code))
                .ForMember(d => d.CompanyName, opt => opt.MapFrom(s => s.Name));
            profile.CreateMap<Company, GetCompanyQuery>()
                .ForMember(d => d.CompanyId, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.CompanyCode, opt => opt.MapFrom(s => s.Code))
                .ForMember(d => d.CompanyName, opt => opt.MapFrom(s => s.Name));
        }
    }
}
