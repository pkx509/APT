using System;
using System.ComponentModel.DataAnnotations.Schema;
using GFCA.Domain.Common;
using GFCA.Domain.Entities.Warehouses;

namespace GFCA.Domain.Entities.Documents
{
    public class SaleForecast : AuditableEntity
    {
        public int SaleForecastId { get; set; }
        public string ForecastType { get; set; }

        public Nullable<decimal> M01JAN { get; set; }
        public Nullable<decimal> M02FEB { get; set; }
        public Nullable<decimal> M03MAR { get; set; }
        public Nullable<decimal> M04APR { get; set; }
        public Nullable<decimal> M05MAY { get; set; }
        public Nullable<decimal> M06JUN { get; set; }
        public Nullable<decimal> M07JUL { get; set; }
        public Nullable<decimal> M08AUG { get; set; }
        public Nullable<decimal> M09SEP { get; set; }
        public Nullable<decimal> M10OCT { get; set; }
        public Nullable<decimal> M11NOV { get; set; }
        public Nullable<decimal> M12DEC { get; set; }

        [ForeignKey("Document")]
        public int DocumentId { get; set; }
        [ForeignKey("DocumentId")]
        public virtual Document Document { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public string ProductCode { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }
        public string BrandCode { get; set; }
        public string BrandName { get; set; }

        public SaleForecast()
        {
        }
    }
}
