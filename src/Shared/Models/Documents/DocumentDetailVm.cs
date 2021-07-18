using System;
using System.Collections.Generic;
using GFCA.Shared.Models.Dto;

namespace GFCA.Shared.Models.Vm
{
    public class DocumentDetailVm
    {
        public virtual IList<BudgetDto> Budgets { get; set; }
        public virtual IList<FixedContractDto> FixedContracts { get; set; }
        public virtual IList<SaleForecastDto> SaleForecasts { get; set; }

    }
}
