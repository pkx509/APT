using System;
using System.ComponentModel.DataAnnotations.Schema;
using GFCA.Domain.Entities.Workflows;

namespace GFCA.Domain.Entities.Documents
{
    public class DocumentAction
    {
        public int DocumentActionId { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string Comment { get; set; }

        [ForeignKey("Actor")]
        public Nullable<int> ActorId { get; set; }
        [ForeignKey("ActorId")]
        public virtual Actor Actor { get; set; }
        public string ActorName { get; set; }

        [ForeignKey("Document")]
        public Nullable<int> DocumentId { get; set; }
        [ForeignKey("DocumentId")]
        public virtual Document Document { get; set; }

        public DocumentAction()
        {
        }
    }
}
