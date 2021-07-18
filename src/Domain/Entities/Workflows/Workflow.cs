using System;
using System.Collections.Generic;
using GFCA.Domain.Common;
using GFCA.Domain.Entities.Documents;

namespace GFCA.Domain.Entities.Workflows
{
    public class Workflow : AuditableEntity
    {
        public int WorkflowId { get; set; }
        public string WorkflowName { get; set; }
        public string WorkflowDesc { get; set; }
        public DateTime BeginDate { get; set; } = DateTime.Today;
        public DateTime EndDate { get; set; } = DateTime.MaxValue;

        public virtual ICollection<WorkflowState> WorkflowStates { get; set; } = new HashSet<WorkflowState>();
        public virtual ICollection<DocumentType> DocumentTypes { get; set; } = new HashSet<DocumentType>();

    }
}
