using System;
using GFCA.Shared.Models.Common;

namespace GFCA.Shared.Models.Dto
{
    public class GLAccountDto : AuditableDtoBase
    {
        public int? AccountId { get; set; } = 0;
        public int? GLGroupId { get; set; }
        public string GLGroupName { get; set; }
        //public GLGroupDto? GLGroup { get; set; }
        public string GLCode { get; set; }
        public string GLName { get; set; }
        public string Purpose { get; set; }
        public string Remark { get; set; }
    }

}
