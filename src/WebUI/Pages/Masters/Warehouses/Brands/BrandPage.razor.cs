using System;
using GFCA.Shared.Models.Dto;
using Syncfusion.Blazor.Grids;

namespace GFCA.WebUI.Pages.Masters.Warehouses.Brands
{
    public partial class BrandPage
    {
        public DialogSettings DialogParams = new DialogSettings { MinHeight = "400px", Width = "450px" };
        public bool EnabledAdd;
        public void ActionCompleteHandler(ActionEventArgs<BrandDto> args)
        {
            EnabledAdd = false;
            if (args.RequestType.ToString() == "Add")
            {
                EnabledAdd = true;
            }
        }

    }
}
