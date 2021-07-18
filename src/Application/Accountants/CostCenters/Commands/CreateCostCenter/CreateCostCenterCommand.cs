using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Accountants;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Accountants.CostCenters.Commands.CreateCostCenter
{
    public class CreateCostCenterCommand
        : CostCenterDto
        , IMapFrom<CostCenterDto>
        , IRequest<int>
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<CreateCostCenterCommand, CostCenterDto>();
            profile.CreateMap<CostCenterDto, CostCenter>();
            profile.CreateMap<CreateCostCenterCommand, CostCenter>();
        }

    }
}
