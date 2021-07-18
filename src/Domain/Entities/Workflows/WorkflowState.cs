using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GFCA.Domain.Entities.Workflows
{
    public class WorkflowState
    {
        public int WorkflowStateId { get; set; }
        public string StateName { get; set; }
        public string StateDesc { get; set; }
        public string NotifySubject { get; set; }
        public string NotifyMessage { get; set; }
        public virtual DateTime BeginDate { get; set; } = DateTime.Today; //equ with document workflow's creating date
        public virtual DateTime EndDate { get; set; } = DateTime.MaxValue;

        [ForeignKey("Workflow")]
        public int WorkflowId { get; set; }
        [ForeignKey("WorkflowId")]
        public virtual Workflow Workflow { get; set; }

        [ForeignKey("PreviousState")]
        public virtual Nullable<int> PreviousStateId { get; set; }
        [ForeignKey("PreviousStateId")]
        public virtual WorkflowState PreviousState { get; set; }

        public virtual ICollection<ActorState> ActorStates { get; set; }
        public virtual ICollection<StateFlowItem> StateFlowItems { get; set; }
        public virtual ICollection<StateProcess> StateProcesses { get; set; }
        public virtual ICollection<WorkflowState> NextState { get; set; }

        public WorkflowState()
        {
            ActorStates = new HashSet<ActorState>();
            StateFlowItems = new HashSet<StateFlowItem>();
            StateProcesses = new HashSet<StateProcess>();

        }

    }

}
