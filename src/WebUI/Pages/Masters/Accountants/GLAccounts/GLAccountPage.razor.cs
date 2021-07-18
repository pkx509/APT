using System;
using GFCA.Shared.Models.Dto;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Grids;

namespace GFCA.WebUI.Pages.Masters.Accountants.GLAccounts
{
    public partial class GLAccountPage
    {

        SfComboBox<int?, GLGroupDto> cmbGLGroup { get; set; }
        public int? GroupIdSelected { get; set; }

        public DialogSettings DialogParams = new DialogSettings { MinHeight = "400px", Width = "700px" };
        public bool EnabledAdd;
        public void ActionCompleteHandler(ActionEventArgs<GLAccountDto> args)
        {
            EnabledAdd = false;
            /*
            if (args.RequestType.ToString() == "Add")
            {
                EnabledAdd = true;
            }
            */
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Add)
            {
                EnabledAdd = true;
            }
        }

        public void ActionBeginHandler(ActionEventArgs<GLAccountDto> args)
        {
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.BeginEdit)
            {
                //args.RowData.GLGroup.GroupId
                var accItem = args.EditContext.Model as GLAccountDto;
                GroupIdSelected = accItem.GLGroupId;

                //cmbGLGroup.GetItems();
            }
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
            {
                //args.Data.Status = (WeatherForecastState)Enum.Parse(typeof(WeatherForecastState), DropDownList.Value);
                GLGroupDto data = cmbGLGroup.GetDataByValue(cmbGLGroup.Value);
                //args.Data.GLGroup = data;
                int Id = cmbGLGroup.Value??0;
                args.Data.GLGroupId = data.GroupId;
                args.Data.GLGroupName = data.GroupName;
            }
        }
        /*
        public void OnGLGroupChange(CustomValueSpecifierEventArgs<GLGroupDto> args)
        {
            args.Item = new GLGroupDto() { GroupName = args.Text, GroupPolicy = args.Item.GroupPolicy };
        }
        */
    }

}
