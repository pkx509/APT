using System;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;

namespace GFCA.WebUI.Pages.Masters.Warehouses.Products
{
    public class ProductService : DataAdaptor
    {

        private readonly HttpClient _http;
        private readonly Microsoft.AspNetCore.Components.NavigationManager _navigationManager;
        private const string _api = "/api/Product";
        private const string _currentUrl = "/Master/Warehouses/Products";
        public IList<ProductDto> DataSource { get; set; } = new List<ProductDto>();

        #region [ Constructor ]

        public ProductService(HttpClient httpClient, Microsoft.AspNetCore.Components.NavigationManager navigationManager) : base()
        {
            _http = httpClient;
            _navigationManager = navigationManager;
        }

        ~ProductService()
        {
            _http.Dispose();
        }

        #endregion [ Constructor ]

        public override async Task<object> ReadAsync(DataManagerRequest dataManagerRequest, string key = null)
        {

            var json = await _http.GetFromJsonAsync<ProductVm>(_api);
            DataSource = json.Products;
            IEnumerable<ProductDto> dataSource = DataSource;
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

            counter = dataSource.Cast<ProductDto>().Count();


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
            var dto = value as ProductDto;
            var response = await _http.PostAsJsonAsync<ProductDto>(_api, dto);
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

            var dto = (value as ProductDto);
            var response = await _http.PutAsJsonAsync<ProductDto>($"{_api}/{dto.ProductId}", dto);
            _navigationManager.NavigateTo(_currentUrl);

            return value;
        }


    }
}
