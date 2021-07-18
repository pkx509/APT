using System;
using GFCA.Shared.Models.Dto;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Grids;

namespace GFCA.WebUI.Pages.Masters.Documents.DocumentTypes
{
    public partial class DocumentTypePage
    {
        public DialogSettings DialogParams = new DialogSettings { MinHeight = "400px", Width = "450px" };
        public bool EnabledAdd;
        public bool PermitAdding;
        public bool PermitEditing;
        public bool PermitDeleting;
        public SfComboBox<int?, WorkflowDto> cmbWorkflow;

        protected override void OnParametersSet()
        {
            PermitAdding = true;
            PermitEditing = true;
            PermitDeleting = false;
            base.OnParametersSet();
        }
        public void ActionCompleteHandler(ActionEventArgs<DocumentTypeDto> args)
        {
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
            {
                var doc = args.Data as DocumentTypeDto;
                if (args.Action.ToLower() == "add")
                {

                }
                if (args.Action.ToLower() == "edit")
                {

                }

            }
        }

        public void ActionBeginHandler(ActionEventArgs<DocumentTypeDto> args)
        {
            EnabledAdd = false;
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Add)
            {
                EnabledAdd = true;
            }

            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
            {
                args.Data.WorkflowId = cmbWorkflow.Value;
            }

        }

        public void CellSaveHandler(CellSaveArgs<DocumentTypeDto> args)
        {

        }

        public void CellSavedHandler(CellSaveArgs<DocumentTypeDto> args)
        {
        }
    }
}
