using FairWorks.DTO;
using FairWorks.WebUI.Clients.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Clients.Services
{
    public class SectorClient : ISectorClient
    {
        private readonly HttpClient _httpClient;
        public SectorClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<SectorDTO>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("http://localhost:57892/api/Sector/GetAll");
            var result = HttpResponseExtensions.ContentAsType<List<SectorDTO>>(response);
            return result;
        }
    }
}
