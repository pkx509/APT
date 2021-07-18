using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Organizations;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Organizations.Departments.Commands.CreateDepartment
{
    public class CreateDepartmentCommand
        : DepartmentDto
        , IMapFrom<DepartmentDto>
        , IRequest<int>
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<CreateDepartmentCommand, DepartmentDto>();
            profile.CreateMap<DepartmentDto, Department>();
            profile.CreateMap<CreateDepartmentCommand, Department>();
        }

    }
}
