using System;
using GFCA.Shared.Models.Dto;
using GFCA.WebUI.Services;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;

namespace GFCA.WebUI.Pages.Masters.Sales.TradeActivities
{
    public partial class TradeActivityPage
    {
        [Inject] private HelperService HelperService { get; set; }
        public DialogSettings DialogParams = new DialogSettings { MinHeight = "400px", Width = "700px" };
        public bool EnabledAdd;
        public void ActionCompleteHandler(ActionEventArgs<TradeActivityDto> args)
        {
            EnabledAdd = false;
            if (args.RequestType.ToString() == "Add")
            {
                EnabledAdd = true;
            }
        }

        public void GotoGLAccounts()
        {
            HelperService.ChangePage(@"/Master/Accountants/GLAccounts");
        }
        public void GotoGLGroups()
        {
            HelperService.ChangePage(@"/Master/Accountants/GLGroups");
        }
    }

}
