using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GFCA.Domain.Entities.Workflows
{
    public class ActorState
    {
        public int ActorStateId { get; set; }
        public string ContactType { get; set; }
        public string RoleState { get; set; }
        public string User { get; set; }
        public string Position { get; set; }

        [ForeignKey("OperatorCondition")]
        public int OperatorConditionId { get; set; }
        [ForeignKey("OperatorConditionId")]
        public virtual OperatorCondition OperatorCondition { get; set; }

        public string OperatorCode { get; set; }
        public Nullable<decimal> LimitValue { get; set; }

        [ForeignKey("Actor")]
        public int ActorId { get; set; }
        [ForeignKey("ActorId")]
        public virtual Actor Actor { get; set; }

        [ForeignKey("WorkflowState")]
        public int WorkflowStateId { get; set; }
        [ForeignKey("WorkflowStateId")]
        public virtual WorkflowState WorkflowState { get; set; }

        public ActorState()
        {
            
        }
    }
}
