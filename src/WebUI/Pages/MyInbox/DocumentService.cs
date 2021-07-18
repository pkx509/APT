using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using GFCA.Shared.Models.Dto;
using GFCA.Shared.Models.Vm;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;

namespace GFCA.WebUI.Pages.MyInbox
{
    public class DocumentService : DataAdaptor
    {
        private readonly HttpClient _http;
        private readonly Microsoft.AspNetCore.Components.NavigationManager _navigationManager;
        private const string _api = "/api/Document";
        private const string _currentUrl = "/MyInbox/WorkflowState";
        public IList<DocumentDto> DataSource { get; set; } = new List<DocumentDto>();

        #region [ Constructor ]

        public DocumentService(HttpClient httpClient, Microsoft.AspNetCore.Components.NavigationManager navigationManager) : base()
        {
            _http = httpClient;
            _navigationManager = navigationManager;
        }

        ~DocumentService()
        {
            _http.Dispose();
        }

        #endregion [ Constructor ]

        public override async Task<object> ReadAsync(DataManagerRequest dataManagerRequest, string key = null)
        {

            var json = await _http.GetFromJsonAsync<DocumentVm>(_api);
            DataSource = json.Documents;
            IEnumerable<DocumentDto> _GridData = DataSource;
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

            _Count = _GridData.Cast<DocumentDto>().Count();


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
            var dto = value as DocumentDto;
            var response = await _http.PostAsJsonAsync<DocumentDto>(_api, dto);
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

            var dto = (value as DocumentDto);
            var response = await _http.PutAsJsonAsync<DocumentDto>($"{_api}/{dto.DocumentId}", dto);
            _navigationManager.NavigateTo(_currentUrl);

            return value;
        }

    }
}
