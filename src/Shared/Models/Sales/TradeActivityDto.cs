using System;
using GFCA.Shared.Models.Common;

namespace GFCA.Shared.Models.Dto
{
    public class TradeActivityDto : AuditableDtoBase
    {
        public int? TradeActivityId { get; set; }
        public string ActivityType { get; set; } //AP Sale / AP MKT
        public string ActivityCode { get; set; }
        public string ActivityName { get; set; }

        public int? GLGroupId { get; set; }
        public string GLGroupName { get; set; }
        //public virtual GLGroupDto GLGroup { get; set; }

        public int? AccountId { get; set; }
        public string GLCode { get; set; }
        public string GLName { get; set; }
        public string Purpose { get; set; }
        
        //public virtual GLAccountDto GLAccount { get; set; }

        public string Value { get; set; }
        public string Remark { get; set; }

        public bool IsFixedContract { get; set; }
        public bool IsDeductable { get; set; }
        public bool HaveSaleInTHB { get; set; }
        public bool HaveSaleInGrossSale { get; set; }
        public bool HaveSaleInNotSale { get; set; }

        public bool HaveSaleOutTHB { get; set; }
        public bool HaveSaleOutGrossSale { get; set; }
        public bool HaveSaleOutNotSale { get; set; }

        public bool AbsAmt { get; set; }

    }
}
