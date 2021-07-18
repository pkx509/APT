using System;
using GFCA.Shared.Models.Common;

namespace GFCA.Shared.Models.Dto
{
    public class ProductDto : AuditableDtoBase
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string SKU { get; set; }
        public string Color { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public string Shape { get; set; }
        public string Size { get; set; }
        public int? QTY { get; set; }
        public string UOM { get; set; }
        public decimal? LTP { get; set; }

        public int? BrandId { get; set; }
        public string BrandCode { get; set; }
        public string BrandName { get; set; }

        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }

    }
}
