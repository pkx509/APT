using System;
namespace GFCA.Shared.Models.Dto
{
    public class ActorStateDto
    {
        public int ActorStateId { get; set; }
        public string ContactType { get; set; }
        public string RoleState { get; set; }
        public string User { get; set; }
        public string Position { get; set; }

        public int OperatorConditionId { get; set; }
        public string OperatorCode { get; set; }
        public Nullable<decimal> LimitValue { get; set; }

        public int ActorId { get; set; }
        public string ActorName { get; set; }

        public int WorkflowStateId { get; set; }
        public string WorkflowStateName { get; set; }

    }
}
