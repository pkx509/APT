using System;
using System.Collections.Generic;
using GFCA.Shared.Models.Dto;

namespace GFCA.Shared.Models.Vm
{
    public class ProductCategoryVm
    {
        public IList<ProductCategoryDto> ProductCategories { get; set; }
    }
}