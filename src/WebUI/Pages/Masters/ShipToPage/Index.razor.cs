using System;
using GFCA.WebUI.Models.SAP;
using System.Collections.Generic;
using System.Threading.Tasks;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;
using Syncfusion.Blazor.Grids;

namespace GFCA.WebUI.Pages.Masters.ShipToPage
{
    public partial class Index
    {

        public DialogSettings DialogParams = new DialogSettings { MinHeight = "400px", Width = "450px" };
        public bool EnabledAdd;
        public void ActionCompleteHandler(ActionEventArgs<ShipToMaster> args)
        {
            EnabledAdd = false;
            if (args.RequestType.ToString() == "Add")
            {
                EnabledAdd = true;
            }
        }

        public class ShipToAdaptor : DataAdaptor
        {

            public List<ShipToMaster> DataSource { get; set; } = new List<ShipToMaster>();

            public override async Task<Object> ReadAsync(DataManagerRequest dataManagerRequest, string key = null)
            {

                await Task.Delay(100); //To mimic asynchronous operation, we delayed this operation using Task.Delay
                IEnumerable<ShipToMaster> _GridData = DataSource;
                int _Count = 0;
                if (dataManagerRequest.Search != null && dataManagerRequest.Search.Count > 0)
                {
                    _GridData = DataOperations.PerformSearching(_GridData, dataManagerRequest.Search);
                }

                if (dataManagerRequest.Sorted != null && dataManagerRequest.Sorted.Count > 0)
                {
                    _GridData = DataOperations.PerformSorting(_GridData, dataManagerRequest.Sorted);
                }

                if (dataManagerRequest.Where != null && dataManagerRequest.Where.Count > 0)
                {
                    _GridData = DataOperations.PerformFiltering(_GridData, dataManagerRequest.Where, dataManagerRequest.Where[0].Operator);
                }

                _Count = _GridData.Cast<ShipToMaster>().Count();


                if (dataManagerRequest.Skip != 0)
                {
                    _GridData = _GridData.Skip(dataManagerRequest.Skip); //Paging
                }
                if (dataManagerRequest.Take != 0)
                {
                    _GridData = _GridData.Take(dataManagerRequest.Take);
                }

                return dataManagerRequest.RequiresCounts ?
                    new DataResult()
                    {
                        Result = _GridData,
                        Count = _Count
                    }
                    : (object)_GridData;
            }

            public override async Task<Object> InsertAsync(DataManager dataManager, object value, string key)
            {
                await Task.Delay(100); //To mimic asynchronous operation, we delayed this operation using Task.Delay
                DataSource.Insert(0, value as ShipToMaster);
                return value;
            }

            public override async Task<object> RemoveAsync(DataManager dataManager, object value, string keyField, string key)
            {
                await Task.Delay(100); //To mimic asynchronous operation, we delayed this operation using Task.Delay
                string data = value.ToString();
                DataSource.Remove(DataSource.Where(x => x.Code == data).FirstOrDefault());
                return value;
            }

            public override async Task<object> UpdateAsync(DataManager dataManager, object value, string keyField, string key)
            {
                await Task.Delay(100); //To mimic asynchronous operation, we delayed this operation using Task.Delay
                var val = (value as ShipToMaster);
                var data = DataSource.Where(x => x.Code == val.Code).FirstOrDefault();
                if (data != null)
                {
                    //data.Code = val.Code;
                    data.Name = val.Name;
                    data.SaleOrg = val.SaleOrg;
                    data.DistributionChannel = val.DistributionChannel;
                    data.MaterialGroup = val.MaterialGroup;
                    data.UOM = val.UOM;
                    data.PerPack = val.PerPack;
                    data.CustMatCode = val.CustMatCode;
                    data.CustMatName = val.CustMatName;
                    data.CustUOM = val.CustUOM;

                }
                return value;
            }
        }

    }
}
