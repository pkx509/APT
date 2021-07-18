using System;
using System.Collections.Generic;
using GFCA.Domain.Entities.Accountants;

namespace GFCA.Domain.Entities.Organizations
{
    public class Company : Organization
    {

        public string Address { get; set; }

        public virtual ICollection<Department> Departments { get; set; } = new HashSet<Department>();
        public virtual ICollection<CostCenter> CostCenters { get; set; } = new HashSet<CostCenter>();

        public Company()
        {

        }

        private Company(int companyId, string companyName)
        {
            this.Id = companyId;
            this.Name = companyName;
        }

        public static Company CreateInstant(int companyId, string companyName)
        {
            return new Company(companyId, companyName);
        }
    }
}
