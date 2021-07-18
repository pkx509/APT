using System;
using System.Collections.Generic;
using GFCA.Shared.Models.Dto;

namespace GFCA.Shared.Models.Vm
{
    public class ProductVm
    {
        public IList<ProductDto> Products { get; set; }
    }
}
