using System;
using System.Collections.Generic;
using GFCA.Domain.Entities.Documents;
using GFCA.Domain.Entities.Organizations;
using GFCA.Domain.Entities.Sales;

namespace GFCA.Domain.Entities.Accountants
{
    public class CostCenter
    {
        public int CostCenterId { get; set; }
        public string CenterCode { get; set; }
        public string CenterName { get; set; }
        public string Site { get; set; }

        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public int? SourceFundId { get; set; }
        public virtual SourceFund SourceFund { get; set; }

        public virtual ICollection<FixedContract> FixedContracts { get; set; }
        public virtual ICollection<Budget> Budgets { get; set; }


        public CostCenter()
        {
            FixedContracts = new HashSet<FixedContract>();
            Budgets = new HashSet<Budget>();
        }
    }
}
