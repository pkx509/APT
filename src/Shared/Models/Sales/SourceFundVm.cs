using System;
using System.Collections.Generic;
using GFCA.Shared.Models.Dto;

namespace GFCA.Shared.Models.Vm
{
    public class SourceFundVm
    {
        public virtual IList<SourceFundDto> SourceFunds { get; set; }

    }
}
