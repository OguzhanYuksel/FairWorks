using FairWorks.DTO;
using FairWorks.WebUI.Clients.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Clients.Services
{
    public class FairClient : IFairClient
    {
        private readonly HttpClient _httpClient;
        public FairClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<FairDTO>> GetAllFairs()
        {
            var response = await _httpClient.GetAsync("http://localhost:57892/api/Fair/GetAll");
            var result = HttpResponseExtensions.ContentAsType<List<FairDTO>>(response);
            return result;
        }
    }
}
