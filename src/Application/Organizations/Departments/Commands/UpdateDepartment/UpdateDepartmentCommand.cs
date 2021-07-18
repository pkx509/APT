using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Organizations;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Organizations.Departments.Commands.UpdateDepartment
{
    public class UpdateDepartmentCommand
        : DepartmentDto
        , IMapFrom<DepartmentDto>
        , IRequest
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<UpdateDepartmentCommand, DepartmentDto>();
            profile.CreateMap<DepartmentDto, Department>();
            profile.CreateMap<UpdateDepartmentCommand, Department>();
        }

    }
}
