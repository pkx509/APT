using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Warehouses;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;

namespace GFCA.Application.Warehouses.Brands.Queries.GetBrand
{
    public class GetBrandQuery
        : BrandDto
        , IMapFrom<GetBrandQuery>
        , IRequest<BrandVm>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetBrandQuery, BrandDto>();
            profile.CreateMap<BrandDto, Brand>();
            profile.CreateMap<GetBrandQuery, Brand>();

            profile.CreateMap<Brand, BrandDto>();
            profile.CreateMap<Brand, GetBrandQuery>();
        }
    }
}
