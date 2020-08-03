using FairWorks.DTO;
using FairWorks.WebUI.Clients.Abstract;
using System;
using System.Collections.Generic;
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

        public async Task<FairDTO> AddFair(FairDTO fairDTO)
        {

            HttpRequestMessage requestMessage = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost:57892/api/Fair/Add"),
                Method = HttpMethod.Post,
                Content = HttpRequestExtensions.ContentAsByteJson(fairDTO),
            };
            var response = await _httpClient.SendAsync(requestMessage);
            var result = HttpResponseExtensions.ContentAsType<FairDTO>(response);
            return result;
        }

        public async Task<List<FairDTO>> GetAllFairs()
        {
            var response = await _httpClient.GetAsync("http://localhost:57892/api/Fair/GetAll");
            var result = HttpResponseExtensions.ContentAsType<List<FairDTO>>(response);
            return result;
        }
    }
}
