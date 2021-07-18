using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GFCA.Domain.Common;
using GFCA.Domain.Entities.Documents;
using GFCA.Domain.Entities.Sales;

namespace GFCA.Domain.Entities.Accountants
{
    public class GLAccount : AuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountId { get; set; }
        public string GLCode { get; set; }
        public string GLName { get; set; }
        public string Purpose { get; set; }
        public string Remark { get; set; }

        [ForeignKey("GLGroup")]
        public Nullable<int> GLGroupId { get; set; }
        [ForeignKey("GLGroupId")]
        public virtual GLGroup GLGroup { get; set; }
        public virtual ICollection<FixedContract> FixedContracts { get; set; } = new HashSet<FixedContract>();
        public virtual ICollection<TradeInvesment> TradeInvesments { get; set; } = new HashSet<TradeInvesment>();
        public virtual ICollection<TradeActivity> TradeActivities { get; set; } = new HashSet<TradeActivity>();


    }
}
