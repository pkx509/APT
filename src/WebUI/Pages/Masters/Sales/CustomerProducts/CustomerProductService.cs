using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;
using System.Net.Http;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using System.Net.Http.Json;

namespace GFCA.WebUI.Pages.Masters.Sales.CustomerProducts
{

    public class CustomerProductService : DataAdaptor
    {

        private readonly HttpClient _http;
        private readonly Microsoft.AspNetCore.Components.NavigationManager _navigationManager;
        private const string _api = "/api/CustomerProduct";
        private const string _currentUrl = "/Master/CustomerProducts";
        public IList<CustomerProductDto> DataSource { get; set; } = new List<CustomerProductDto>();

        #region [ Constructor ]

        public CustomerProductService(HttpClient httpClient, Microsoft.AspNetCore.Components.NavigationManager navigationManager) : base()
        {
            _http = httpClient;
            _navigationManager = navigationManager;
        }

        ~CustomerProductService()
        {
            _http.Dispose();
        }

        #endregion [ Constructor ]

        public override async Task<object> ReadAsync(DataManagerRequest dataManagerRequest, string key = null)
        {

            var json = await _http.GetFromJsonAsync<CustomerProductVm>(_api);
            DataSource = json.CustomerProducts;
            IEnumerable<CustomerProductDto> dataSource = DataSource;
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

            counter = dataSource.Cast<CustomerProductDto>().Count();


            if (dataManagerRequest.Skip != 0)
            {
                dataSource = dataSource.Skip(dataManagerRequest.Skip); //Paging
            }
            if (dataManagerRequest.Take != 0)
            {
                dataSource = dataSource.Take(dataManagerRequest.Take);
            }

            return dataManagerRequest.RequiresCounts
                ? new DataResult()
                {
                    Result = dataSource,
                    Count = counter
                }
                : (object)dataSource;
        }
        public override async Task<object> InsertAsync(DataManager dataManager, object value, string key)
        {
            var dto = value as CustomerProductDto;
            var response = await _http.PostAsJsonAsync<CustomerProductDto>(_api, dto);
            return value;
        }
        public override async Task<object> RemoveAsync(DataManager dataManager, object value, string keyField, string key)
        {
            int data = Convert.ToInt32(value);
            var response = await _http.DeleteAsync($"{_api}/{data}");

            return value;
        }
        public override async Task<object> UpdateAsync(DataManager dataManager, object value, string keyField, string key)
        {

            var dto = (value as CustomerProductDto);
            var response = await _http.PutAsJsonAsync<CustomerProductDto>($"{_api}/{dto.CustomerProductId}", dto);
            _navigationManager.NavigateTo(_currentUrl);

            return value;
        }

    }

}
