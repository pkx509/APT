using System;
using GFCA.Shared.Models.Dto;
using Syncfusion.Blazor.Grids;
namespace GFCA.WebUI.Pages.Masters.Accountants.CostCenters
{
    public partial class CostCenterPage
    {

        public DialogSettings DialogParams = new DialogSettings { MinHeight = "400px", Width = "450px" };
        public bool EnabledAdd;
        public void ActionCompleteHandler(ActionEventArgs<CostCenterDto> args)
        {
            EnabledAdd = false;
            if (args.RequestType.ToString() == "Add")
            {
                EnabledAdd = true;
            }
        }

    }
}
