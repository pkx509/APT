using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Warehouses;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Warehouses.ProductCategories.Commands.CreateProductCategory
{
    public class CreateProductCategoryCommand
        : ProductCategoryDto
        , IMapFrom<CreateProductCategoryCommand>
        , IRequest<int>
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<CreateProductCategoryCommand, ProductCategoryDto>();
            profile.CreateMap<ProductCategoryDto, ProductCategory>();
            profile.CreateMap<CreateProductCategoryCommand, ProductCategory>();
        }

    }
}
