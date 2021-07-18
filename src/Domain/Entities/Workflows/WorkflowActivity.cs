using System;
using System.Collections.Generic;

namespace GFCA.Domain.Entities.Workflows
{
    public class WorkflowActivity
    {

        public int ActivityId { get; set; }
        public string ActivityCode { get; set; }
        public string ActivityName { get; set; }
        public int ActivityPiority { get; set; }

        public virtual ICollection<StateProcess> StateProcesses { get; set; }
        public WorkflowActivity()
        {
            StateProcesses = new HashSet<StateProcess>();
        }
        
    }
}
