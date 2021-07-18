using System;
using System.ComponentModel.DataAnnotations.Schema;
using GFCA.Domain.Common;
using GFCA.Domain.Entities.Accountants;
using GFCA.Domain.Entities.Sales;
using GFCA.Domain.Entities.Warehouses;

namespace GFCA.Domain.Entities.Documents
{
    public class FixedContract : AuditableEntity
    {
        public int FixedContractId { get; set; }

        public string ConditionType { get; set; }
        public string ContractCategory { get; set; }
        public string ContractDesc { get; set; }
        public string UOM { get; set; }
        public string DateRefForm { get; set; }
        public Nullable<decimal> M01JAN { get; set; }
        public Nullable<decimal> M02FEB { get; set; }
        public Nullable<decimal> M03MAR { get; set; }
        public Nullable<decimal> M04APR { get; set; }
        public Nullable<decimal> M05MAY { get; set; }
        public Nullable<decimal> M06JUN { get; set; }
        public Nullable<decimal> M07JUL { get; set; }
        public Nullable<decimal> M08AUG { get; set; }
        public Nullable<decimal> M09SEP { get; set; }
        public Nullable<decimal> M10OCT { get; set; }
        public Nullable<decimal> M11NOV { get; set; }
        public Nullable<decimal> M12DEC { get; set; }

        [ForeignKey("Document")]
        public Nullable<int> DocumentId { get; set; }
        [ForeignKey("DocumentId")]
        public Document Document { get; set; }

        [ForeignKey("GLAccount")]
        public int? AccountId { get; set; }
        [ForeignKey("AccountId")]
        public GLAccount GLAccount { get; set; }

        [ForeignKey("CostCenter")]
        public int? CostCenterId { get; set; }
        [ForeignKey("CostCenterId")]
        public CostCenter CostCenter { get; set; }

        [ForeignKey("Brand")]
        public int? BrandId { get; set; }
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }

        [ForeignKey("TradeInvesment")]
        public int? TradeInvesmentId { get; set; }
        [ForeignKey("TradeInvesmentId")]
        public TradeInvesment TradeInvesment { get; set; }

        public FixedContract()
        {
        }
    }
}
