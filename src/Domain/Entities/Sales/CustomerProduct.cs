using System;
using System.ComponentModel.DataAnnotations.Schema;
using GFCA.Domain.Entities.BusinessParties;
using GFCA.Domain.Entities.Warehouses;

namespace GFCA.Domain.Entities.Sales
{
    public class CustomerProduct
    {
        public int CustomerProductId { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("ProductCategory")]
        public int ProductCategoryId { get; set; }
        [ForeignKey("ProductCategoryId")]
        public virtual ProductCategory ProductCategory { get; set; }
        
    }
}
