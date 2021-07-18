using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using GFCA.Shared.Models.Vm;
using GFCA.Shared.Models.Dto;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;

namespace GFCA.WebUI.Pages.Masters.BusinessParties.Customers
{
    public class CustomerService : DataAdaptor
    {

        private readonly HttpClient _http;
        private readonly Microsoft.AspNetCore.Components.NavigationManager _navigationManager;
        private const string _api = "/api/Customer";
        private const string _currentUrl = "/Master/BusinessParties/Customers";
        public IList<CustomerDto> DataSource { get; set; } = new List<CustomerDto>();

        #region [ Constructor ]

        public CustomerService(HttpClient httpClient, Microsoft.AspNetCore.Components.NavigationManager navigationManager) : base()
        {
            _http = httpClient;
            _navigationManager = navigationManager;
        }

        ~CustomerService()
        {
            _http.Dispose();
        }

        #endregion [ Constructor ]

        public override async Task<Object> ReadAsync(DataManagerRequest dataManagerRequest, string key = null)
        {

            var json = await _http.GetFromJsonAsync<CustomerVm>(_api);
            DataSource = json.Customers;
            //await Task.Delay(100); //To mimic asynchronous operation, we delayed this operation using Task.Delay
            IEnumerable<CustomerDto> dataSource = DataSource;
            int counter = 0;
            if (dataManagerRequest.Search != null && dataManagerRequest.Search.Count > 0)
            {
                dataSource = DataOperations.PerformSearching(dataSource, dataManagerRequest.Search);
            }

            if (dataManagerRequest.Sorted != null && dataManagerRequest.Sorted.Count > 0)
            {
                dataSource = DataOperations.PerformSorting(dataSource, dataManagerRequest.Sorted);
            }

            if (dataManagerRequest.Where != null && dataManagerRequest.Where.Count > 0)
            {
                dataSource = DataOperations.PerformFiltering(dataSource, dataManagerRequest.Where, dataManagerRequest.Where[0].Operator);
            }

            counter = dataSource.Cast<CustomerDto>().Count();


            if (dataManagerRequest.Skip != 0)
            {
                dataSource = dataSource.Skip(dataManagerRequest.Skip); //Paging
            }
            if (dataManagerRequest.Take != 0)
            {
                dataSource = dataSource.Take(dataManagerRequest.Take);
            }

            return dataManagerRequest.RequiresCounts ?
                new DataResult()
                {
                    Result = dataSource,
                    Count = counter
                }
                : (object)dataSource;
        }
        public override async Task<Object> InsertAsync(DataManager dataManager, object value, string key)
        {
            //await Task.Delay(100); //To mimic asynchronous operation, we delayed this operation using Task.Delay
            //DataSource.Insert(0, value as CustomerDto);

            var dto = value as CustomerDto;
            var response = await _http.PostAsJsonAsync<CustomerDto>(_api, dto);
            return value;
        }
        public override async Task<object> RemoveAsync(DataManager dataManager, object value, string keyField, string key)
        {
            /*
            await Task.Delay(100); //To mimic asynchronous operation, we delayed this operation using Task.Delay
            string data = value.ToString();
            DataSource.Remove(DataSource.Where(x => x.CustomerCode == data).FirstOrDefault());
            */

            int data = Convert.ToInt32(value);
            var response = await _http.DeleteAsync($"{_api}/{data}");

            return value;
        }
        public override async Task<object> UpdateAsync(DataManager dataManager, object value, string keyField, string key)
        {
            /*
            await Task.Delay(100); //To mimic asynchronous operation, we delayed this operation using Task.Delay
            var val = (value as CustomerDto);
            var data = DataSource.Where(x => x.CustomerCode == val.CustomerCode).FirstOrDefault();
            if (data != null)
            {
                //data.Code = val.Code;
            }
            */
            var dto = (value as CustomerDto);
            var response = await _http.PutAsJsonAsync<CustomerDto>($"{_api}/{dto.CustomerId}", dto);
            _navigationManager.NavigateTo(_currentUrl);

            return value;
        }

    }
}
