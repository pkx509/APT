using System;
using GFCA.Shared.Models.Common;

namespace GFCA.Shared.Models.Dto
{
    public class ProductCategoryDto : AuditableDtoBase
    {
        public int ProductCategoryId { get; set; }
        public string ProductCategoryCode { get; set; }
        public string ProductCategoryName { get; set; }

    }
}
