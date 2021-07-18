using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using GFCA.Shared.Models.Vm;
using GFCA.Shared.Models.Dto;
using Syncfusion.Blazor.Data;
using Syncfusion.Blazor;

namespace GFCA.WebUI.Pages.Masters.Sales.Channels
{
    public class ChannelService : DataAdaptor
    {

        private readonly HttpClient _http;
        private readonly Microsoft.AspNetCore.Components.NavigationManager _navigationManager;
        private string _api = "/api/Channel";
        private const string _currentUrl = "/Master/Sales/Channels";
        public IList<ChannelDto> DataSource { get; set; } = new List<ChannelDto>();

        #region [ Constructor ]

        public ChannelService(HttpClient httpClient, Microsoft.AspNetCore.Components.NavigationManager navigationManager) : base()
        {
            _http = httpClient;
            _navigationManager = navigationManager;
        }

        ~ChannelService()
        {
            _http.Dispose();
        }

        #endregion [ Constructor ]

        public override async Task<object> ReadAsync(DataManagerRequest dataManagerRequest, string key = null)
        {

            var json = await _http.GetFromJsonAsync<ChannelVm>(_api);
            DataSource = json.Channels;
            await Task.Delay(100); //To mimic asynchronous operation, we delayed this operation using Task.Delay
            IEnumerable<ChannelDto> dataSource = DataSource;
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

            counter = dataSource.Cast<ChannelDto>().Count();


            if (dataManagerRequest.Skip != 0)
                dataSource = dataSource.Skip(dataManagerRequest.Skip); //Paging

            if (dataManagerRequest.Take != 0)
                dataSource = dataSource.Take(dataManagerRequest.Take); //Items each page


            return dataManagerRequest.RequiresCounts ?
                new DataResult()
                {
                    Result = dataSource,
                    Count = counter
                }
                : (object)dataSource;
        }
        public override async Task<object> InsertAsync(DataManager dataManager, object value, string key)
        {
            //await Task.Delay(100); //To mimic asynchronous operation, we delayed this operation using Task.Delay
            //DataSource.Insert(0, value as CustomerDto);

            var dto = value as ChannelDto;
            var response = await _http.PostAsJsonAsync<ChannelDto>(_api, dto);
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

            var dto = (value as ChannelDto);
            var response = await _http.PutAsJsonAsync<ChannelDto>($"{_api}/{dto.ChannelId}", dto);
            _navigationManager.NavigateTo(_currentUrl);

            return value;
        }

    }
}
