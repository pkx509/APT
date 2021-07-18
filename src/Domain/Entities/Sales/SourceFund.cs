using System;
using System.Collections.Generic;
using GFCA.Domain.Entities.Accountants;
using GFCA.Domain.Entities.Documents;

namespace GFCA.Domain.Entities.Sales
{
    public class SourceFund
    {
        public int SourceFundId { get; set; }
        public string FundCode { get; set; }
        public string FundName { get; set; }
        public string FundDesc { get; set; }

        public virtual ICollection<Budget> Budgets { get; set; } = new HashSet<Budget>();
        public virtual ICollection<CostCenter> CostCenters { get; set; } = new HashSet<CostCenter>();

    }
}
