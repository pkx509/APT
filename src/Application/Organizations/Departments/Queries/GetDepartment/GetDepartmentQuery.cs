using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Organizations;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;

namespace GFCA.Application.Organizations.Departments.Queries.GetDepartment
{
    public class GetDepartmentQuery
        : DepartmentDto
        , IMapFrom<GetDepartmentQuery>
        , IRequest<DepartmentVm>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetDepartmentQuery, DepartmentDto>();
            profile.CreateMap<DepartmentDto, Department>();
            profile.CreateMap<GetDepartmentQuery, Department>();

            profile.CreateMap<Department, DepartmentDto>();
            profile.CreateMap<Department, GetDepartmentQuery>();
        }
    }
}
