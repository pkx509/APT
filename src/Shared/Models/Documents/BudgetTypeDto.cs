using System;
using GFCA.Shared.Models.Common;

namespace GFCA.Shared.Models.Dto
{
    public class BudgetTypeDto : AuditableDtoBase
    {
        public int BudgetTypeId { get; set; } = 0;
        public string BudgetTypeCode { get; set; }
        public string BudgetTypeName { get; set; }
        public string BudgetTypeDesc { get; set; }

    }
}
