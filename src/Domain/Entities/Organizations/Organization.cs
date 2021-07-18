using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace GFCA.Domain.Entities.Organizations
{
    [NotMapped]
    public class Organization : Party
    {

        public override decimal Cost => Children.Sum(s => s.Cost);

        public override int CountChild => Children.Count();

        public virtual ICollection<Party> Children { get; } = new HashSet<Party>();

        public override void Add(Party item) => Children.Add(item);
        public override void Remove(Party item) => Children.Remove(item);

    }
}
