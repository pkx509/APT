using System;
namespace GFCA.Shared.Models.Dto
{
    public class WorkflowActionDto
    {
        public int ActionId { get; set; } = 0;
        public string ActionCode { get; set; }
        public string ActionName { get; set; }
        public int ActionPiority { get; set; }

    }
}
