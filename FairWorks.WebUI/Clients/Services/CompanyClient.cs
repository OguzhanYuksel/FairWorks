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
            //_httpClient.BaseAddress = new Uri("http://localhost:57892");
        }
        public async Task<CompanyDTO> AddCompany(CompanyDTO companyDTO)
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost:57892/api/Company/Add"),
                Method = HttpMethod.Post,
                Content = HttpRequestExtensions.ContentAsByteJson(companyDTO),
            };
            var response = await _httpClient.SendAsync(requestMessage);
            var result = HttpResponseExtensions.ContentAsType<CompanyDTO>(response);
            return result;
        }

        public async Task<List<CompanyDTO>> GetAllCompanies()
        {
            var response = await _httpClient.GetAsync("http://localhost:57892/api/Company/GetAll");
            var result = HttpResponseExtensions.ContentAsType<List<CompanyDTO>>(response);
            return result;
        }

        public async Task<List<CompanyProfileDTO>> GetAllCompanyProfiles()
        {
            var response = await _httpClient.GetAsync("http://localhost:57892/api/Company/GetCompanyProfiles");
            var result = HttpResponseExtensions.ContentAsType<List<CompanyProfileDTO>>(response);
            return result;
        }
       

    }
}
