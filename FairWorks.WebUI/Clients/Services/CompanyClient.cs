using FairWorks.DTO;
using FairWorks.WebUI.Clients.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Clients.Services
{
    public class CompanyClient : ICompanyClient
    {
        private readonly HttpClient _httpClient;
        public CompanyClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<CompanyProfileDTO>> GetAllCompanyProfiles()
        {
            var response = await _httpClient.GetAsync("http://localhost:57892/api/Company/GetCompanyProfiles");
            var result = HttpResponseExtensions.ContentAsType<List<CompanyProfileDTO>>(response);
            return result;
        }
    }
}
