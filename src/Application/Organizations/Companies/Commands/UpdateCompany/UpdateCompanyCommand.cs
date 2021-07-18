using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Organizations;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Organizations.Companies.Commands.UpdateCompany
{
    public class UpdateCompanyCommand
        : CompanyDto
        , IMapFrom<CompanyDto>
        , IRequest
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<UpdateCompanyCommand, CompanyDto>();
            profile.CreateMap<CompanyDto, Company>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.CompanyId))
                .ForMember(d => d.Code, opt => opt.MapFrom(s => s.CompanyCode))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.CompanyName));
            profile.CreateMap<UpdateCompanyCommand, Company>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.CompanyId))
                .ForMember(d => d.Code, opt => opt.MapFrom(s => s.CompanyCode))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.CompanyName));
        }

    }
}
