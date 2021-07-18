using System;
namespace GFCA.Shared.Models.Dto
{
    public class WorkflowDto
    {
        public int WorkflowId { get; set; } = 0;
        public string WorkflowName { get; set; }
        public string WorkflowDesc { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
