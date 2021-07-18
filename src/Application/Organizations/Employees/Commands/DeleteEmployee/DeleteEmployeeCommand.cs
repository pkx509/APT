using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Organizations;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Organizations.Employees.Commands.DeleteEmployee
{
    public class DeleteEmployeeCommand
        : EmployeeDto
        , IMapFrom<EmployeeDto>
        , IRequest
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<DeleteEmployeeCommand, EmployeeDto>();
            profile.CreateMap<EmployeeDto, Employee>();
            profile.CreateMap<DeleteEmployeeCommand, Employee>();
        }

    }
}
