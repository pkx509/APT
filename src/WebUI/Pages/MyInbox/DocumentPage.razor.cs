using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Navigations;

namespace GFCA.WebUI.Pages.MyInbox
{
    public partial class DocumentPage
    {
        private List<ItemModel> myToolbar = new List<ItemModel>();
        public SfGrid<DocumentDto> myGridData { get; set; }
        public static IList<DocumentDto> _myDocuments { get; set; }
        [Parameter]
        public string WorkflowState { get; set; }
        public DialogSettings DialogParams = new DialogSettings { MinHeight = "400px", Width = "450px" };

        public DocumentPage()
        {
            myToolbar.Add(new ItemModel { Text = "New Request", TooltipText = "New Request", PrefixIcon = "", Id = "btnRequest" });
            myToolbar.Add(new ItemModel { Text = "Submit", TooltipText = "Submit", PrefixIcon = "", Id = "btnSubmit" });
            myToolbar.Add(new ItemModel { Text = "Confirm", TooltipText = "Confirm", PrefixIcon = "", Id = "btnConfirm" });
            myToolbar.Add(new ItemModel { Text = "Approve", TooltipText = "Approve", PrefixIcon = "", Id = "btnApprove" });
            myToolbar.Add(new ItemModel { Text = "Reject", TooltipText = "Reject", PrefixIcon = "", Id = "btnReject" });
            myToolbar.Add(new ItemModel { Text = "Cancel ", TooltipText = "Cancel ", PrefixIcon = "", Id = "btnCancel" });
            myToolbar.Add(new ItemModel { Text = "Review", TooltipText = "Review", PrefixIcon = "", Id = "btnReview" });
            myToolbar.Add(new ItemModel { Text = "Commit", TooltipText = "Commit", PrefixIcon = "", Id = "btnCommit" });
        }

        public bool EnabledAdd;
        public void ActionCompleteHandler(ActionEventArgs<DocumentDto> args)
        {
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
            {
                var doc = args.Data as DocumentDto;
                if (args.Action.ToLower() == "add")
                {

                }
                if (args.Action.ToLower() == "edit")
                {
                    
                }
                
            }
        }

        public void ActionBeginHandler(ActionEventArgs<DocumentDto> args)
        {
            EnabledAdd = false;
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Add)
            {
                EnabledAdd = true;
            }

        }

    }
}
