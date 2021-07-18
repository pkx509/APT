using System;
namespace GFCA.Shared.Models.Common
{
    public abstract class AuditableDtoBase
    {
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual string UpdatedBy { get; set; }
        public virtual DateTime? UpdatedDate { get; set; }
    }
}
