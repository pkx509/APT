using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GFCA.Domain.Entities.Workflows
{
    public class StateProcess
    {

        public int StateProcessId { get; set; }

        public string ActivityCode { get; set; }
        public string ActivityName { get; set; }
        public int ActionPiority { get; set; }

        public string ActionCode { get; set; }
        public string ActionName { get; set; }
        public int ActivityPiority { get; set; }
        

        [ForeignKey("WorkflowState")]
        public int WorkflowStateId { get; set; }
        [ForeignKey("WorkflowStateId")]
        public virtual WorkflowState WorkflowState { get; set; }

        [ForeignKey("WorkflowActivity")]
        public int ActivityId { get; set; }
        [ForeignKey("ActivityId")]
        public virtual WorkflowActivity WorkflowActivity { get; set; }

        [ForeignKey("WorkflowAction")]
        public int ActionId { get; set; }
        [ForeignKey("ActionId")]
        public virtual WorkflowAction WorkflowAction { get; set; }
        
        
        public StateProcess()
        {
        }
        public StateProcess(int stateProcessId, int workflowStateId, int activityId, int actionId
            , string activityCode, string actionCode, string activityName, string actionName
            , int activityPiority, int actionPiority)
        {
            StateProcessId = stateProcessId;
            WorkflowStateId = workflowStateId;
            ActivityId = activityId;
            ActionId = actionId;
            ActivityCode = activityCode;
            ActionCode = actionCode;
            ActivityName = activityName;
            ActionName = actionName;
            ActivityPiority = activityPiority;
            ActionPiority = actionPiority;
        }
    }
}
