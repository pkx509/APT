using System;
using GFCA.Shared.Models.Common;

namespace GFCA.Shared.Models.Dto
{
    public class GLGroupDto : AuditableDtoBase
    {

        public int? GroupId { get; set; }
        public string GroupPolicy { get; set; }
        public string GroupName { get; set; }

    }
}
