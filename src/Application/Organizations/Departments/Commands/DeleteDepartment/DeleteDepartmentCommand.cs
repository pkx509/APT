using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Organizations;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Organizations.Departments.Commands.DeleteDepartment
{
    public class DeleteDepartmentCommand
        : DepartmentDto
        , IMapFrom<DepartmentDto>
        , IRequest
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<DeleteDepartmentCommand, DepartmentDto>();
            profile.CreateMap<DepartmentDto, Department>();
            profile.CreateMap<DeleteDepartmentCommand, Department>();
        }

    }
}
