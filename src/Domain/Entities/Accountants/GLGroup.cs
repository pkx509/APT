using System;
using System.Collections.Generic;
using GFCA.Domain.Common;

namespace GFCA.Domain.Entities.Accountants
{
    public class GLGroup : AuditableEntity
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupPolicy { get; set; }

        public virtual ICollection<GLAccount> GLAccounts { get; set; } = new HashSet<GLAccount>();
    }
}
