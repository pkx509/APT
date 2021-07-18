using System;
using System.Collections.Generic;
using GFCA.Shared.Models.Dto;

namespace GFCA.Shared.Models.Vm
{
    public class DocumentVm
    {
        //public DocumentFilter DocumentFilter { get; set; }
        public IList<DocumentDto> Documents { get; set; }

    }
}
