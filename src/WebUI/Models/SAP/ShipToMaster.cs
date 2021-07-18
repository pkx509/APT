using System;
namespace GFCA.WebUI.Models.SAP
{
    public class ShipToMaster
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string SalesOrg { get; set; }
        public string DistributionChannel { get; set; }
        public int? PartnerCounter { get; set; }
        public string PFCode { get; set; }
        public string PFName { get; set; }

        public ShipToMaster()
        {
        }
    }
}
