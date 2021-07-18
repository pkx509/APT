using System;
using MediatR;

namespace GFCA.Application.Warehouses.ProductCategories.Commands.DeleteProductCategory
{
    public class DeleteProductCategoryCommand
        : IRequest
    {

        public int ProductCategoryId { get; set; }

    }
}
