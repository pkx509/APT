using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Organizations;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Organizations.Employees.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommand
        : EmployeeDto
        , IMapFrom<EmployeeDto>
        , IRequest
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<UpdateEmployeeCommand, EmployeeDto>();
            profile.CreateMap<EmployeeDto, Employee>();
            profile.CreateMap<UpdateEmployeeCommand, Employee>();
        }

    }
}
