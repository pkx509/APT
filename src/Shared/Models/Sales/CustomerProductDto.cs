using System;

namespace GFCA.Shared.Models.Dto
{
    public class CustomerProductDto
    {
        public int CustomerProductId { get; set; } = 0;
        public int? CustomerId { get; set; }
        public int? ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }

        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CustMaterial { get; set; }
        public string CustUOM { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialDescription { get; set; }
        public string SAPUOM { get; set; }
        public string SaleOrg { get; set; }
        public string Channel { get; set; }
        public string Division { get; set; }
        public int? CustPack { get; set; }
        public int? DHPack { get; set; }

    }
    
}