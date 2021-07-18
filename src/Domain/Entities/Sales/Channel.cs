using System;
using System.Collections.Generic;
using GFCA.Domain.Common;
using GFCA.Domain.Entities.Documents;

namespace GFCA.Domain.Entities.Sales
{
    public class Channel : AuditableEntity
    {
        public int ChannelId { get; set; }
        public string ChannelCode { get; set; }
        public string ChannelName { get; set; }
        public string ChannelDesc { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<SupplierCustomer> SupplierCustomers { get; set; }
        public virtual ICollection<TradeInvesment> TradeInvesments { get; set; }

        public Channel()
        {
            Documents = new HashSet<Document>();
            SupplierCustomers = new HashSet<SupplierCustomer>();
            TradeInvesments = new HashSet<TradeInvesment>();
        }
    }
}
