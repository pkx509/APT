using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using GFCA.Domain.Common;

namespace GFCA.Domain.Entities.Organizations
{
    [NotMapped]
    public abstract class Party : AuditableEntity
    {
        public int Id { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }

        public abstract decimal Cost { get; }

        public abstract int CountChild { get; }

        public abstract void Add(Party item);
        public abstract void Remove(Party item);

    }
}
