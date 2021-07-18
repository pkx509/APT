using System;
using GFCA.Shared.Models.Common;

namespace GFCA.Shared.Models.Dto
{
    public class EmployeeDto : AuditableDtoBase
    {
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }

        public virtual DepartmentDto Department { get; set; }
    }
}
