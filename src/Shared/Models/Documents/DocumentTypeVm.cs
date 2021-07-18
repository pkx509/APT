using System;
using System.Collections.Generic;
using GFCA.Shared.Models.Dto;

namespace GFCA.Shared.Models.Vm
{
    public class DocumentTypeVm
    {
        public virtual IList<DocumentTypeDto> DocumentTypes { get; set; }
    }
}
