using System;
using System.Collections.Generic;
using GFCA.Shared.Models.Dto;

namespace GFCA.Shared.Models.Vm
{
    public class WorkflowVm
    {
        public IList<WorkflowDto> Workflows { get; set; }
    }
}
