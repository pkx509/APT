using System;
namespace GFCA.Shared.Models.Dto
{
    public class WorkflowActivityDto
    {
        public int ActivityId { get; set; } = 0;
        public string ActivityCode { get; set; }
        public string ActivityName { get; set; }
        public int ActivityPiority { get; set; }

    }
}
