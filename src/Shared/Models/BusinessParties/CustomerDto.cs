using System;
using System.Collections.Generic;
using GFCA.Shared.Models.Common;
using GFCA.Shared.Models.Dto;

namespace GFCA.Shared.Models.Dto
{
    public class CustomerDto : AuditableDtoBase
    {
        public int CustomerId { get; set; } = 0;
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerGroup { get; set; }
        public string ShortName { get; set; }
        public string AccountNo { get; set; }
        public string SalesBy { get; set; }


        public virtual IList<SupplierDto> Suppliers { get; set; } = null;
        public virtual IList<ChannelDto> Channels { get; set; } = null;
    }
}
