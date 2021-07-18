using System;
using System.Collections.Generic;
using GFCA.Domain.Common;
using GFCA.Domain.Entities.Documents;
using GFCA.Domain.Entities.Sales;

namespace GFCA.Domain.Entities.BusinessParties
{
    public class Customer : AuditableEntity
    {

        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string ShortName { get; set; }
        public string AccountNo { get; set; }
        public string CustomerGroup { get; set; }
        public string Distributor { get; set; }

        public virtual ICollection<SupplierCustomer> SupplierCustomers { get; set; } = new HashSet<SupplierCustomer>();
        public virtual ICollection<Document> Documents { get; set; } = new HashSet<Document>();
        public virtual ICollection<Channel> Channels { get; set; } = new HashSet<Channel>();
        public virtual ICollection<CustomerProduct> CustomerProducts { get; set; } = new HashSet<CustomerProduct>();
        public virtual ICollection<TradeInvesment> TradeInvesments { get; set; } = new HashSet<TradeInvesment>();

    }
}
