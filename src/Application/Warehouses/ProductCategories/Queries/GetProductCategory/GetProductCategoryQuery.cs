using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Warehouses;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;

namespace GFCA.Application.Warehouses.ProductCategories.Queries.GetProductCategory
{
    public class GetProductCategoryQuery
        : ProductCategoryDto
        , IMapFrom<GetProductCategoryQuery>
        , IRequest<ProductCategoryVm>
    {

        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetProductCategoryQuery, ProductCategoryDto>();
            profile.CreateMap<ProductCategoryDto, ProductCategory>();
            profile.CreateMap<GetProductCategoryQuery, ProductCategory>();

            profile.CreateMap<ProductCategory, ProductCategoryDto>();
            profile.CreateMap<ProductCategory, GetProductCategoryQuery>();
        }

    }
}
