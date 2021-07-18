using System;
using System.Collections.Generic;
using GFCA.Shared.Models.Dto;

namespace GFCA.Shared.Models.Vm
{
    public class CustomerProductVm
    {
        public virtual IList<CustomerProductDto> CustomerProducts { get; set; }
    }
    
}
