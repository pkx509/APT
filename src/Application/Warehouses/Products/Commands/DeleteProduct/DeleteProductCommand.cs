using System;
using MediatR;

namespace GFCA.Application.Warehouses.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest
    {
        public int ProductId { get; set; }
    }
}
