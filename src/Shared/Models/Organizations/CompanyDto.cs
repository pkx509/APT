using System;
using GFCA.Shared.Models.Common;

namespace GFCA.Shared.Models.Dto
{
    public class CompanyDto : AuditableDtoBase
    {
        public int CompanyId { get; set; } = 0;
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanySite { get; set; }
        public string Address { get; set; }
        public decimal? Cost { get; set; }
    }
}
