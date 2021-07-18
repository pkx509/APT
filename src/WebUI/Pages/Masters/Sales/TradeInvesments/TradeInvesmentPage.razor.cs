using System;
using GFCA.Shared.Models.Dto;
using Syncfusion.Blazor.Grids;

namespace GFCA.WebUI.Pages.Masters.Sales.TradeInvesments
{
    public partial class TradeInvesmentPage
    {
        public DialogSettings DialogParams = new DialogSettings { MinHeight = "400px", Width = "450px" };
        public bool EnabledAdd;
        public void ActionCompleteHandler(ActionEventArgs<TradeInvesmentDto> args)
        {
            EnabledAdd = false;
            if (args.RequestType.ToString() == "Add")
            {
                EnabledAdd = true;
            }
        }

    }
}
