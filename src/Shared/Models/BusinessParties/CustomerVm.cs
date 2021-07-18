using System;
using System.Collections.Generic;
using GFCA.Shared.Models.Dto;

namespace GFCA.Shared.Models.Vm
{
    public class CustomerVm
    {
        public IList<CustomerDto> Customers { get; set; }
    }
}
