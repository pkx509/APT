using System;
using GFCA.Shared.Models.Common;

namespace GFCA.Shared.Models.Dto
{
    public class DepartmentDto : AuditableDtoBase
    {
        public int DepartmentId { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }

        public virtual CompanyDto Company { get; set; }

    }
}
