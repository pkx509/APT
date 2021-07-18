using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Warehouses;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Warehouses.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand
        : ProductDto
        , IMapFrom<UpdateProductCommand>
        , IRequest
    {
        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<UpdateProductCommand, ProductDto>();
            profile.CreateMap<ProductDto, Product>();
            profile.CreateMap<UpdateProductCommand, Product>();
        }
    }
}
