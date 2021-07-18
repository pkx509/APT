using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;

namespace GFCA.WebUI.Pages.Masters.Warehouses.Brands
{
    public class BrandService : DataAdaptor
    {
        private readonly HttpClient _http;
        private readonly Microsoft.AspNetCore.Components.NavigationManager _navigationManager;
        private const string _api = "/api/Brand";
        private const string _currentUrl = "/Master/Warehouses/Brands";
        public IList<BrandDto> DataSource { get; set; } = new List<BrandDto>();

        #region [ Constructor ]

        public BrandService(HttpClient httpClient, Microsoft.AspNetCore.Components.NavigationManager navigationManager) : base()
        {
            _http = httpClient;
            _navigationManager = navigationManager;
        }

        ~BrandService()
        {
            _http.Dispose();
        }

        #endregion [ Constructor ]

        public override async Task<object> ReadAsync(DataManagerRequest dataManagerRequest, string key = null)
        {

            var json = await _http.GetFromJsonAsync<BrandVm>(_api);
            DataSource = json.Brands;
            IEnumerable<BrandDto> _GridData = DataSource;
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

            _Count = _GridData.Cast<BrandDto>().Count();


            if (dataManagerRequest.Skip != 0)
            {
                _GridData = _GridData.Skip(dataManagerRequest.Skip); //Paging
            }
            if (dataManagerRequest.Take != 0)
            {
                _GridData = _GridData.Take(dataManagerRequest.Take);
            }

            return dataManagerRequest.RequiresCounts
                ? new DataResult()
                {
                    Result = _GridData,
                    Count = _Count
                }
                : (object)_GridData;
        }
        public override async Task<object> InsertAsync(DataManager dataManager, object value, string key)
        {
            var dto = value as BrandDto;
            var response = await _http.PostAsJsonAsync<BrandDto>(_api, dto);
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

            var dto = (value as BrandDto);
            var response = await _http.PutAsJsonAsync<BrandDto>($"{_api}/{dto.BrandId}", dto);
            _navigationManager.NavigateTo(_currentUrl);

            return value;
        }

    }

}
