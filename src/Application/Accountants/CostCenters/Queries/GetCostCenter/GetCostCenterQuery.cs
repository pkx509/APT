using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Accountants;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;

namespace GFCA.Application.Accountants.CostCenters.Queries.GetCostCenter
{
    public class GetCostCenterQuery
        : CostCenterDto
        , IMapFrom<GetCostCenterQuery>
        , IRequest<CostCenterVm>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetCostCenterQuery, CostCenterDto>();
            profile.CreateMap<CostCenterDto, CostCenter>()
                .ForMember(d => d.CostCenterId, o => o.MapFrom(s => s.CostCenterId))
                .ForMember(d => d.CenterCode, o => o.MapFrom(s => s.CostCenterCode))
                .ForMember(d => d.CenterName, o => o.MapFrom(s => s.CostCenterName))
                .ForMember(d => d.Site, o => o.MapFrom(s => s.Site))
                ;

            profile.CreateMap<GetCostCenterQuery, CostCenter>()
                .ForMember(d => d.CostCenterId, o => o.MapFrom(s => s.CostCenterId))
                .ForMember(d => d.CenterCode, o => o.MapFrom(s => s.CostCenterCode))
                .ForMember(d => d.CenterName, o => o.MapFrom(s => s.CostCenterName))
                .ForMember(d => d.Site, o => o.MapFrom(s => s.Site))
                ;

            profile.CreateMap<CostCenter, CostCenterDto>()
                .ForMember(d => d.CostCenterId, o => o.MapFrom(s => s.CostCenterId))
                .ForMember(d => d.CostCenterCode, o => o.MapFrom(s => s.CenterCode))
                .ForMember(d => d.CostCenterName, o => o.MapFrom(s => s.CenterName))
                .ForMember(d => d.Site, o => o.MapFrom(s => s.Site))
                ;

            profile.CreateMap<CostCenter, GetCostCenterQuery>()
                .ForMember(d => d.CostCenterId, o => o.MapFrom(s => s.CostCenterId))
                .ForMember(d => d.CostCenterCode, o => o.MapFrom(s => s.CenterCode))
                .ForMember(d => d.CostCenterName, o => o.MapFrom(s => s.CenterName))
                .ForMember(d => d.Site, o => o.MapFrom(s => s.Site))
                ;
        }
    }

}
