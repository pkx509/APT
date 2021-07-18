using System;
using GFCA.Shared.Models.Common;

namespace GFCA.Shared.Models.Dto
{
    public class DocumentTypeDto : AuditableDtoBase
    {
        public int DocumentTypeId { get; set; } = 0;
        public int? WorkflowId { get; set; }
        public string DocumentTypeCode { get; set; }
        public string DocumentTypeName { get; set; }
        public string DocumentTypeDesc { get; set; }

    }
}
