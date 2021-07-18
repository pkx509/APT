using System;
using System.Collections.Generic;
using GFCA.Shared.Models.Dto;

namespace GFCA.Shared.Models.Vm
{
    public class BudgetTypeVm
    {
        public virtual IList<BudgetTypeDto> BudgetTypes { get; set; }
    }
}
