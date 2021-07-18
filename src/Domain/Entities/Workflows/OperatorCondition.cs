using System;
using System.Collections.Generic;

namespace GFCA.Domain.Entities.Workflows
{
    public class OperatorCondition
    {
        public int OperatorConditionId { get; set; }
        public string OperatorCode { get; set; }
        public string OperatoDesc { get; set; }

        public ICollection<ActorState> ActorStates { get; set; }
        public OperatorCondition()
        {
            ActorStates = new HashSet<ActorState>();
        }
    }
}
