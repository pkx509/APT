using System;
using AutoMapper;
using GFCA.Application.Common.Mappings;
using GFCA.Domain.Entities.Warehouses;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Warehouses.Brands.Commands.CreateBrand
{
    public class CreateBrandCommand
        : BrandDto
        , IMapFrom<CreateBrandCommand>
        , IRequest<int>
    {
        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<CreateBrandCommand, BrandDto>();
            profile.CreateMap<DocumentTypeDto, Brand>();
            profile.CreateMap<CreateBrandCommand, Brand>();
        }

    }
}
