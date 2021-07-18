using System;
using System.Collections.Generic;

namespace GFCA.Domain.Entities.Workflows
{
    public class WorkflowAction
    {

        public int ActionId { get; set; }
        public string ActionCode { get; set; }
        public string ActionName { get; set; }
        public int ActionPiority { get; set; }

        public ICollection<StateProcess> StateProcesses { get; set; } = new HashSet<StateProcess>();

    }
}
