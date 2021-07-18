using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Organizations;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;

namespace GFCA.Application.Organizations.Employees.Queries.GetEmployee
{
    public class GetEmployeeQuery
        : EmployeeDto
        , IMapFrom<GetEmployeeQuery>
        , IRequest<EmployeeVm>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetEmployeeQuery, EmployeeDto>();
            profile.CreateMap<EmployeeDto, Employee>();
            profile.CreateMap<GetEmployeeQuery, Employee>();

            profile.CreateMap<Employee, EmployeeDto>();
            profile.CreateMap<Employee, GetEmployeeQuery>();
        }
    }
}
