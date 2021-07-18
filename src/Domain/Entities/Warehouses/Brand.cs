using System;
using System.Collections.Generic;
using GFCA.Domain.Common;
using GFCA.Domain.Entities.Documents;
using GFCA.Domain.Entities.Sales;

namespace GFCA.Domain.Entities.Warehouses
{
    public class Brand : AuditableEntity
    {
        public int BrandId { get; set; }
        public string BrandCode { get; set; }
        public string BrandName { get; set; }

        public virtual ICollection<SupplierCustomer> SupplierCustomers { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<FixedContract> FixedContracts { get; set; }
        public virtual ICollection<SaleForecast> SaleForecasts { get; set; }
        public Brand()
        {
            SupplierCustomers = new HashSet<SupplierCustomer>();
            Products = new HashSet<Product>();
            Budgets = new HashSet<Budget>();
            FixedContracts = new HashSet<FixedContract>();
            SaleForecasts = new HashSet<SaleForecast>();
        }
    }
}
