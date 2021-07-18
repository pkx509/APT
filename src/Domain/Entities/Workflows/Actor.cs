using System;
using System.Collections.Generic;
using GFCA.Domain.Entities.Documents;

namespace GFCA.Domain.Entities.Workflows
{
    public class Actor
    {

        public int ActorId { get; set; }
        public string ActorCode { get; set; }
        public string ActorName { get; set; }
        public string ActorEmail { get; set; }

        
        public virtual ICollection<ActorState> ActorStates { get; set; }
        public virtual ICollection<DocumentAction> DocumentActions { get; set; }
        public Actor()
        {
            ActorStates = new HashSet<ActorState>();
            DocumentActions = new HashSet<DocumentAction>();
        }
    }
}
