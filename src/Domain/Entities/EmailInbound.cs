using System;
using GFCA.Domain.Common;
using System.ComponentModel.DataAnnotations;
namespace GFCA.Domain.Entities
{
    public class EmailInbound : AuditableEntity
    {
        public int EmailID { get; set; }
        public string FromEmail { get; set; }
        public string DataPath { get; set; }
        public int IsActive { get; set; }
        public string Remark { get; set; }

    }
}
