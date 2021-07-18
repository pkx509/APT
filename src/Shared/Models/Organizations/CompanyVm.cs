using System;
using System.Collections.Generic;
using GFCA.Shared.Models.Dto;

namespace GFCA.Shared.Models.Vm
{
    public class CompanyVm
    {
        public IList<CompanyDto> Companies { get; set; }
    }
}
