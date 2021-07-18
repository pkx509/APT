using System;
using System.Collections.Generic;
using GFCA.Shared.Models.Dto;

namespace GFCA.Shared.Models.Vm
{
    public class SaleForecastVm
    {
        public IList<SaleForecastDto> SaleForecasts { get; set; }
    }
}
