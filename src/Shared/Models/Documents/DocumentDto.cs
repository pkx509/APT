using System;
using System.Collections.Generic;

namespace GFCA.Shared.Models.Dto
{
    public class DocumentDto
    {
        //Document Header
        public int? DocumentId { get; set; } = 0;
        public int DocumentTypeId { get; set; }
        public string ReferenceNo { get; set; }
        public int DocumentYear { get; set; } = DateTime.Today.Year;
        public int DocumentMonth { get; set; } = DateTime.Today.Month;
        public int Version { get; set; } = 1;
        public int Revision { get; set; } = 0;

        //Document Detail
        public int ClientId { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }

        public int? CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }

        public int? ChannelId { get; set; }
        public string ChannelCode { get; set; }
        public string ChannelName { get; set; }

        public decimal? TotalSale { get; set; }
        public decimal? TotalInvestment { get; set; }

        //Document Workflow
        public int CurrentStateId { get; set; }
        public int NextStateId { get; set; }
        public string CurrentState { get; set; } = "DRAFT";
        public string NextState { get; set; } = "REVIEW";

        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual IList<FixedContractDto> FixedContracts { get; set; }
        public virtual IList<BudgetDto> Budgets { get; set; }
        public virtual IList<SaleForecastDto> SaleForecasts { get; set; }

    }
}
