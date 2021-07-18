using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Organizations;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Organizations.Companies.Commands.DeleteCompany
{
    public class DeleteCompanyCommand
        : CompanyDto
        , IMapFrom<CompanyDto>
        , IRequest
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<DeleteCompanyCommand, CompanyDto>();
            profile.CreateMap<CompanyDto, Company>();
            profile.CreateMap<DeleteCompanyCommand, Company>();
        }

    }
}
