using System;
using System.Collections.Generic;
using GFCA.Shared.Models.Dto;

namespace GFCA.Shared.Models.Vm
{
    public class EmployeeVm
    {
        public IList<EmployeeDto> Employees { get; set; }
    }
}
