using System;
using GFCA.Shared.Models.Dto;
using Syncfusion.Blazor.Grids;

namespace GFCA.WebUI.Pages.Masters.Accountants.GLGroups
{
    public partial class GLGroupPage
    {
        public DialogSettings DialogParams = new DialogSettings { MinHeight = "400px", Width = "450px" };
        public bool EnabledAdd;
        public void ActionCompleteHandler(ActionEventArgs<GLGroupDto> args)
        {
            EnabledAdd = false;
            if (args.RequestType.ToString() == "Add")
            {
                EnabledAdd = true;
            }
        }
    }
}
