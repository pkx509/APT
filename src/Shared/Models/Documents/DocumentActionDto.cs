using System;
namespace GFCA.Shared.Models.Dto
{
    public class DocumentActionDto
    {

        public int DocumentActionId { get; set; } = 0;
        public DateTime? TimeStamp { get; set; }
        public string Comment { get; set; }

        public int ActorId { get; set; }
        public string ActorName { get; set; }

        public int DocumentId { get; set; }

    }
}
