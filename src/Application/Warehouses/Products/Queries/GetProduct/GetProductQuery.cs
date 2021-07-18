using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Warehouses;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using MediatR;

namespace GFCA.Application.Warehouses.Products.Queries.GetProduct
{
    public class GetProductQuery
        : ProductDto
        , IMapFrom<GetProductQuery>
        , IRequest<ProductVm>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetProductQuery, ProductDto>();
            profile.CreateMap<ProductDto, Product>();
            profile.CreateMap<GetProductQuery, Product>();

            profile.CreateMap<Product, ProductDto>();
            profile.CreateMap<Product, GetProductQuery>();
        }
    }
}
