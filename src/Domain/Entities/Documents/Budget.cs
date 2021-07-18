using System;
using System.ComponentModel.DataAnnotations.Schema;
using GFCA.Domain.Common;
using GFCA.Domain.Entities.Accountants;
using GFCA.Domain.Entities.Sales;
using GFCA.Domain.Entities.Warehouses;

namespace GFCA.Domain.Entities.Documents
{
    public class Budget : AuditableEntity
    {
        public int BudgetId { get; set; }
        public Nullable<decimal> ActualLastYear { get; set; } = 0m;
        public decimal BudgetValue { get; set; } = 0m;
        public Nullable<decimal> BudgetTargetInYear { get; set; } = 0m;
        public Nullable<decimal> PercentContribution { get; set; } = 0m;
        public Nullable<decimal> SaleInvesment { get; set; } = 0m;

        [ForeignKey("Brand")]
        public Nullable<int> BrandId { get; set; }
        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }

        [ForeignKey("Document")]
        public Nullable<int> DocumentId { get; set; }
        [ForeignKey("DocumentId")]
        public virtual Document Document { get; set; }

        [ForeignKey("BudgetType")]
        public Nullable<int> BudgetTypeId { get; set; }
        [ForeignKey("BudgetTypeId")]
        public virtual BudgetType BudgetType { get; set; }

        [ForeignKey("CostCenter")]
        public Nullable<int> CostCenterId { get; set; }
        [ForeignKey("CostCenterId")]
        public virtual CostCenter CostCenter { get; set; }
        public string CenterName { get; set; }

        [ForeignKey("SourceFund")]
        public Nullable<int> SourceFundId { get; set; }
        [ForeignKey("SourceFundId")]
        public virtual SourceFund SourceFund { get; set; }
        public string FundName { get; set; }


        public Budget()
        {
        }
    }
}
