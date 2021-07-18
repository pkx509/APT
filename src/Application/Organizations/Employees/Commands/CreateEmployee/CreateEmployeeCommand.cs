using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Organizations;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Organizations.Employees.Commands.CreateEmployee
{
    public class CreateEmployeeCommand
        : EmployeeDto
        , IMapFrom<EmployeeDto>
        , IRequest<int>
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<CreateEmployeeCommand, EmployeeDto>();
            profile.CreateMap<EmployeeDto, Employee>();
            profile.CreateMap<CreateEmployeeCommand, Employee>();
        }

    }
}
