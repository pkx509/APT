using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Warehouses;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Warehouses.ProductCategories.Commands.UpdateProductCategory
{
    public class UpdateProductCategoryCommand
        : ProductCategoryDto
        , IMapFrom<UpdateProductCategoryCommand>
        , IRequest
    {
        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<UpdateProductCategoryCommand, ProductCategoryDto>();
            profile.CreateMap<ProductDto, ProductCategory>();
            profile.CreateMap<UpdateProductCategoryCommand, ProductCategory>();
        }
    }
}
