using System;
using System.Collections.Generic;
using GFCA.Domain.Common;
using GFCA.Domain.Entities.Documents;
using GFCA.Domain.Entities.Sales;

namespace GFCA.Domain.Entities.BusinessParties
{
    public class Supplier : AuditableEntity
    {
        public int SupplierId { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }

        /*
        [ForeignKey("Brand")]
        public Nullable<int> BrandId { get; set; }
        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }

        [ForeignKey("Customer")]
        public Nullable<int> CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        */

        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<SupplierCustomer> SupplierCustomers { get; set; }
        public Supplier()
        {
            Documents = new HashSet<Document>();
            SupplierCustomers = new HashSet<SupplierCustomer>();
        }
    }
}
