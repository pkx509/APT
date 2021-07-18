using System;
using System.Collections.Generic;

namespace GFCA.Domain.Entities.Documents
{
    public class BudgetType
    {
        public int BudgetTypeId { get; set; }
        public string BudgetTypeCode { get; set; }
        public string BudgetTypeName { get; set; }
        public string BudgetTypeDesc { get; set; }

        public virtual ICollection<Budget> Budgets { get; set; }
        public BudgetType()
        {
            Budgets = new HashSet<Budget>();
        }
    }
}
