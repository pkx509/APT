using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GFCA.Domain.Entities.Organizations
{
    public class Department : Organization
    {

        public string CompanyCode { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

        public Department()
        {

        }
        private Department(int departmantId, string departmentName)
        {
            this.Id = departmantId;
            this.Name = departmentName;
        }

        public static Department CreateInstant(int departmantId, string departmentName)
        {
            return new Department(departmantId, departmentName);
        }

    }
}
