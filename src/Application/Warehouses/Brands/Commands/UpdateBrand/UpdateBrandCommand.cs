using System;
using GFCA.Application.Common.Mappings;
using GFCA.Shared.Models.Dto;
using MediatR;

namespace GFCA.Application.Warehouses.Brands.Commands.UpdateBrand
{
    public class UpdateBrandCommand
        : BrandDto
        , IRequest
        , IMapFrom<UpdateBrandCommand>
    {
        
    }
}
