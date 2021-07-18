using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Warehouses;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Warehouses.Products.Commands.CreateProduct
{
    public class CreateProductCommand
        : ProductDto
        , IMapFrom<CreateProductCommand>
        , IRequest<int>
    {

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<CreateProductCommand, ProductDto>();
            profile.CreateMap<ProductDto, Product>();
            profile.CreateMap<CreateProductCommand, Product>();
        }

    }
}
