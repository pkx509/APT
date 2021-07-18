using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using GFCA.Domain.Common;
using GFCA.Domain.Entities.Accountants;
using GFCA.Domain.Entities.BusinessParties;
using GFCA.Domain.Entities.Sales;

namespace GFCA.Domain.Entities.Documents
{
    public class Document : AuditableEntity
    {
        public int DocumentId { get; set; }
        public string ReferenceNo { get; set; }
        public Nullable<int> DocumentYear { get; set; }
        public Nullable<int> DocumentMonth { get; set; }
        public int Version { get; set; } = 1;
        public int Revision { get; set; } = 0;

        //Document Detail
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string ChannelCode { get; set; }
        public string ChannelName { get; set; }

        public Nullable<decimal> TotalSale { get; set; }
        public Nullable<decimal> TotalInvestment { get; set; }

        //Document Workflow
        public int CurrentStateId { get; set; }
        public string CurrentState { get; set; } = "";
        public int NextStateId { get; set; }
        public string NextState { get; set; } = "";

        [ForeignKey("DocumentType")]
        public Nullable<int> DocumentTypeId { get; set; }
        [ForeignKey("DocumentTypeId")]
        public virtual DocumentType DocumentType { get; set; }
        public string DocumentTypeCode { get; set; }

        [ForeignKey("Supplier")]
        public Nullable<int> SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; }

        [ForeignKey("Channel")]
        public Nullable<int> ChannelId { get; set; }
        [ForeignKey("ChannelId")]
        public virtual Channel Channel { get; set; }

        [ForeignKey("Customer")]
        public Nullable<int> CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }


        public virtual ICollection<DocumentAction> DocumentActions { get; set; }
        public virtual ICollection<SaleForecast> SaleForecasts { get; set; }
        public virtual ICollection<FixedContract> FixedContracts { get; set; }
        public virtual ICollection<Budget> Budgets { get; set; }

        public Document()
        {
            DocumentActions = new HashSet<DocumentAction>();
            SaleForecasts = new HashSet<SaleForecast>();
            FixedContracts = new HashSet<FixedContract>();
            Budgets = new HashSet<Budget>();
        }
    }
}
