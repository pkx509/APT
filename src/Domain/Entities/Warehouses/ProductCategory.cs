using System;
using System.Collections.Generic;
using GFCA.Domain.Entities.Sales;

namespace GFCA.Domain.Entities.Warehouses
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<CustomerProduct> CustomerProducts { get; set; }
        public ProductCategory()
        {
            Products = new HashSet<Product>();
            CustomerProducts = new HashSet<CustomerProduct>();
        }
    }
}
