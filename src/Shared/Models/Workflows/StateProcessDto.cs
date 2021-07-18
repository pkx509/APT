using System;
namespace GFCA.Shared.Models.Dto
{
    public class StateProcessDto
    {
        public int StateProcessId { get; set; }

        public string ActivityCode { get; set; }
        public string ActivityName { get; set; }
        public int ActionPiority { get; set; }

        public string ActionCode { get; set; }
        public string ActionName { get; set; }
        public int ActivityPiority { get; set; }

        public int WorkflowStateId { get; set; }
        public int ActivityId { get; set; }
        public int ActionId { get; set; }
    }
}
