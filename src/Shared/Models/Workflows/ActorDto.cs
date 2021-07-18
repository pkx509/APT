using System;
namespace GFCA.Shared.Models.Dto
{
    public class ActorDto
    {
        public int ActorId { get; set; }
        public string ActorCode { get; set; }
        public string ActorName { get; set; }
        public string ActorEmail { get; set; }

        public int ActorStateId { get; set; }
        
    }
}
