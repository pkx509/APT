using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Accountants;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Accountants.CostCenters.Commands.DeleteCostCenter
{
    public class DeleteCostCenterCommand
        : CostCenterDto
        , IMapFrom<CostCenterDto>
        , IRequest
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<DeleteCostCenterCommand, CostCenterDto>();
            profile.CreateMap<CostCenterDto, CostCenter>();
            profile.CreateMap<DeleteCostCenterCommand, CostCenter>();
        }

    }
}
