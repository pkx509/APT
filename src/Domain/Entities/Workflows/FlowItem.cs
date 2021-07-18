using System;
using System.Collections.Generic;

namespace GFCA.Domain.Entities.Workflows
{
    public class FlowItem
    {
        public int FlowItemId { get; set; }
        public string FlowItemCode { get; set; }
        public string FlowItemName { get; set; }

        public ICollection<StateFlowItem> StateFlowItems { get; set; }

        public FlowItem()
        {
            StateFlowItems = new HashSet<StateFlowItem>();
        }
    }
}
