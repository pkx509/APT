using System;
namespace GFCA.Shared.Models.Dto
{
    public class WorkflowStateDto
    {

        public int WorkflowStateId { get; set; } = 0;
        public string StateName { get; set; }
        public string StateDesc { get; set; }
        public string NotifySubject { get; set; }
        public string NotifyMessage { get; set; }
        public DateTime BeginDate { get; set; } = DateTime.Today; //equ with document workflow's creating date
        public DateTime EndDate { get; set; } = DateTime.MaxValue;

        public int WorkflowId { get; set; }
        public int? PreviousStateId { get; set; }
        
    }
}
