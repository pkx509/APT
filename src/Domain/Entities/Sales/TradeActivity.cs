using System;
using GFCA.Domain.Common;
using GFCA.Domain.Entities.Accountants;

namespace GFCA.Domain.Entities.Sales
{
    public class TradeActivity : AuditableEntity
    {
        public int TradeActivityId { get; set; }
        public int AccountId { get; set; }
        public string ActivityType { get; set; } //AP Sale / AP MKT
        public string ActivityCode { get; set; }
        public string ActivityName { get; set; }

        public string FixedContract { get; set; }
        public string Deductable { get; set; }
        public string SaleInTHBCS { get; set; }
        public string SaleInGrossSale { get; set; }
        public string SaleInNotSale { get; set; }

        public string SaleOutTHBCS { get; set; }
        public string SaleOutGrossSale { get; set; }
        public string SaleOutNotSale { get; set; }

        public string NotRelateSaleAbsAmt { get; set; }

        public string Valuable { get; set; }
        public string Remark { get; set; }

        public virtual GLAccount GLAccount { get; set; }


    }
}
