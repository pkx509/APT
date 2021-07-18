using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using GFCA.WebUI.Models;
using Newtonsoft.Json;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;
using Syncfusion.Blazor.Grids;

namespace GFCA.WebUI.Pages
{
    public partial class Index
    {
        private DialogSettings DialogParams = new DialogSettings { MinHeight = "400px", Width = "450px" };
        public void ActionCompleteHandler(ActionEventArgs<Models.SAP.ProductMaster> args)
        {
            /*
            if (args.RequestType.ToString() == "Add")
            {
                Check = true;
            }
            else
            {
                Check = false;
            }
            */
        }
    }


}
