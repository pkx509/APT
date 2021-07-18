using System;
using System.Collections.Generic;
using GFCA.Shared.Models.Dto;

namespace GFCA.Shared.Models.Vm
{
    public class GLAccountVm
    {
        public IList<GLAccountDto> Accounts { get; set; }
    }
}
