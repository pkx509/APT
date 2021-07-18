using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using GFCA.Domain.Common;
using GFCA.Domain.Entities.Documents;

namespace GFCA.Domain.Entities.Warehouses
{
    public class Product : AuditableEntity
    {

        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string SKU { get; set; }
        public string Color { get; set; }
        public Nullable<decimal> Width { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public string Shape { get; set; }
        public string Size { get; set; }
        public Nullable<int> QTY { get; set; }
        public string UOM { get; set; }
        public Nullable<decimal> LTP { get; set; }


        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }
        public string BrandCode { get; set; }

        [ForeignKey("ProductCategory")]
        public int ProductCategoryId { get; set; }
        [ForeignKey("ProductCategoryId")]
        public ProductCategory ProductCategory { get; set; }
        public string ProductCategoryName { get; set; }

        public virtual ICollection<SaleForecast> SaleForecasts { get; set; }
        public Product()
        {
            SaleForecasts = new HashSet<SaleForecast>();
        }
    }
}
