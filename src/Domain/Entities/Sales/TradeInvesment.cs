using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using GFCA.Domain.Common;
using GFCA.Domain.Entities.Accountants;
using GFCA.Domain.Entities.BusinessParties;
using GFCA.Domain.Entities.Documents;

namespace GFCA.Domain.Entities.Sales
{
    public class TradeInvesment : AuditableEntity
    {
        public int TradeInvesmentId { get; set; }
        public string TradeCode { get; set; }
        public string TradeName { get; set; }
        public string TradeActivity { get; set; }
        public string SubGroup { get; set; }
        public string DataSource { get; set; }
        public bool IsFixedContract { get; set; }
        public bool Deductable { get; set; }
        public string ToleranceLevel { get; set; }
        public decimal? ToleranceLower { get; set; }
        public decimal? ToleranceUpper { get; set; }
        public string CostElement { get; set; }

        [ForeignKey("Channel")]
        public int ChannelId { get; set; }
        [ForeignKey("ChannelId")]
        public virtual Channel Channel { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("GLAccount")]
        public int? AccountId { get; set; }
        [ForeignKey("AccountId")]
        public virtual GLAccount GLAccount { get; set; }

        public ICollection<FixedContract> FixedContracts { get; set; }

        public TradeInvesment()
        {
            FixedContracts = new HashSet<FixedContract>();
        }
    }
}
