using System;
using MediatR;

namespace GFCA.Application.BusinessParties.Suppliers.Commands.DeleteSupplier
{
    public class DeleteSupplierCommand : IRequest
    {
        public int SupplierId { get; set; }
    }
}
