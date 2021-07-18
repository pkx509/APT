using System;
using System.Collections.Generic;
using GFCA.Shared.Models.Dto;

namespace GFCA.Shared.Models.Vm
{
    public class BudgetVm
    {
        public IList<BudgetDto> Budgets { get; set; }
    }
}
