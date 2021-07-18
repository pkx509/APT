using System;
using MediatR;

namespace GFCA.Application.Warehouses.Brands.Commands.DeleteBrand
{
    public class DeleteBrandCommand : IRequest
    {
        public int BrandId { get; set; }
    }
}
