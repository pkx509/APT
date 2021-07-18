using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GFCA.Domain.Entities.Workflows
{
    public class StateFlowItem
    {
        public int StateFlowItemId { get; set; }
        public string FlowItemCode { get; set; }
        public string FlowItemName { get; set; }
        public int Sort { get; set; }

        [ForeignKey("WorkflowState")]
        public int WorkflowStateId { get; set; }
        [ForeignKey("WorkflowStateId")]
        public WorkflowState WorkflowState { get; set; }

        [ForeignKey("FlowItem")]
        public int FlowItemId { get; set; }
        [ForeignKey("FlowItemId")]
        public FlowItem FlowItem { get; set; }

        public StateFlowItem()
        {

        }

    }
}
