using System;
using GFCA.Domain.Common;
using GFCA.Domain.Entities.BusinessParties;
using GFCA.Domain.Entities.Warehouses;

namespace GFCA.Domain.Entities.Sales
{
    public class SupplierCustomer : AuditableEntity
    {

        public int SupplierCustomerId { get; set; }
        public Nullable<int> BrandId { get; set; }
        public Nullable<int> ChannelId { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public int IsActive { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Channel Channel { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Customer Customer { get; set; }
        
    }
}
