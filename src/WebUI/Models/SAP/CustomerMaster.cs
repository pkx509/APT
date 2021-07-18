using System;
namespace GFCA.WebUI.Models.SAP
{
    public class CustomerMaster
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string SaleOrg { get; set; }
        public string DistributionChannel { get; set; }
        public string BlockCode { get; set; }
        public string CustomerCustCode { get; set; }
        public string CustomerCustName { get; set; }

        public CustomerMaster()
        {
        }
    }
}
