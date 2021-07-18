using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using GFCA.Domain.Common;
using GFCA.Domain.Entities.Workflows;

namespace GFCA.Domain.Entities.Documents
{
    public class DocumentType : AuditableEntity
    {
        public int DocumentTypeId { get; set; }

        public string DocumentTypeCode { get; set; }
        public string DocumentTypeName { get; set; }
        public string DocumentTypeDesc { get; set; }

        [ForeignKey("Workflow")]
        public Nullable<int> WorkflowId { get; set; }
        [ForeignKey("WorkflowId")]
        public virtual Workflow Workflow { get; set; }

        public virtual ICollection<Document> Documents { get; set; } = new HashSet<Document>();
        
    }
}
