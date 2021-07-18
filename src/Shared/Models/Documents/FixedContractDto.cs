using System;
namespace GFCA.Shared.Models.Dto
{
    public class FixedContractDto
    {
        public int FixedContractId { get; set; } = 0;
        public int AccountId { get; set; }
        public int BrandId { get; set; }
        public int ProductId { get; set; }
        public int CostCenterId { get; set; }
        public int TradeInvesmentId { get; set; }
        public int DocumentId { get; set; }
        public string ConditionType { get; set; }
        public string ContractCategory { get; set; }
        public string ContractDesc { get; set; }
        public string UOM { get; set; }
        public string DateRefForm { get; set; }
        public decimal? M01JAN { get; set; }
        public decimal? M02FEB { get; set; }
        public decimal? M03MAR { get; set; }
        public decimal? M04APR { get; set; }
        public decimal? M05MAY { get; set; }
        public decimal? M06JUN { get; set; }
        public decimal? M07JUL { get; set; }
        public decimal? M08AUG { get; set; }
        public decimal? M09SEP { get; set; }
        public decimal? M10OCT { get; set; }
        public decimal? M11NOV { get; set; }
        public decimal? M12DEC { get; set; }
    }
}
