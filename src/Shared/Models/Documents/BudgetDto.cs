using System;
namespace GFCA.Shared.Models.Dto
{
    public class BudgetDto
    {

        public int BudgetId { get; set; } = 0;
        public decimal? ActualLastYear { get; set; } = 0m;
        public decimal BudgetValue { get; set; } = 0m;
        public decimal? BudgetTargetInYear { get; set; } = 0m;
        public decimal? PercentContribution { get; set; } = 0m;
        public decimal? SaleInvesment { get; set; } = 0m;

        public int? BrandId { get; set; }

        public int? DocumentId { get; set; }

        public int? BudgetTypeId { get; set; }

        public int? CostCenterId { get; set; }
        public string CenterName { get; set; }

        public int? SourceFundId { get; set; }
        public string FundName { get; set; }

    }
}
