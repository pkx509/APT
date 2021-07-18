using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Organizations;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Organizations.Companies.Commands.CreateCompany
{
    public class CreateCompanyCommand
        : CompanyDto
        , IMapFrom<CompanyDto>
        , IRequest<int>
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<CreateCompanyCommand, CompanyDto>();
            profile.CreateMap<CompanyDto, Company>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.CompanyId))
                .ForMember(d => d.Code, opt => opt.MapFrom(s => s.CompanyCode))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.CompanyName));
            profile.CreateMap<CreateCompanyCommand, Company>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.CompanyId))
                .ForMember(d => d.Code, opt => opt.MapFrom(s => s.CompanyCode))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.CompanyName));
        }

    }
}
