using System;
namespace GFCA.Shared.Models.Dto
{
    public class SaleForecastDto
    {
        public int SaleForecastId { get; set; } = 0;
        public string ForecastType { get; set; }

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

        public int DocumentId { get; set; } = 0;

        public int ProductId { get; set; }
        public string ProductCode { get; set; }

        public int BrandId { get; set; }
        public string BrandCode { get; set; }
        public string BrandName { get; set; }

    }
}
