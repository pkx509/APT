using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using GFCA.Shared.Models.Dto;
using Newtonsoft.Json;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;
using Syncfusion.Blazor.Grids;

namespace GFCA.WebUI.Pages.Masters.Warehouses.Products
{
    public partial class ProductPage
    {

        public DialogSettings DialogParams = new DialogSettings { MinHeight = "400px", Width = "600px" };
        public bool EnabledAdd;
        public void ActionCompleteHandler(ActionEventArgs<ProductDto> args)
        {
            EnabledAdd = false;
            if (args.RequestType.ToString() == "Add")
            {
                EnabledAdd = true;
            }
        }

    }
}
