using System;
using GFCA.Shared.Models.Common;

namespace GFCA.Shared.Models.Dto
{
    public class SupplierCustomerDto : AuditableDtoBase
    {
        public int SupplierCustomerId { get; set; } = 0;

        public int SupplierId { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }

        public int? BrandId { get; set; }
        public string BrandCode { get; set; }
        public string BrandName { get; set; }

        public int? CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerGroup { get; set; }
        public string DistributorCode { get; set; }

        public int? ChannelId { get; set; }
        public string ChannelCode { get; set; }
        public string ChannelName { get; set; }
        public string ChannelDesc { get; set; }

        public bool IsActive { get; set; }

    }
}
