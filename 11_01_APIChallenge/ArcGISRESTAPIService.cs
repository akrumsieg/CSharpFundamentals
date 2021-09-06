using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _11_01_APIChallenge
{
    public class ArcGISRESTAPIService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<Result<SearchSuggestion>> GetResultAsync<SearchSuggestion>(string searchString)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"https://geocode.arcgis.com/arcgis/rest/services/World/GeocodeServer/suggest?text={searchString}&f=json");
            if (response.IsSuccessStatusCode)
            {
                Result<SearchSuggestion> result = await response.Content.ReadAsAsync<Result<SearchSuggestion>>();
                return result;
            }
            return null;
        }
    }
}
