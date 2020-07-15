using FairWorks.DTO;
using FairWorks.WebUI.Clients.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Clients.Services
{
    public class InterviewClient : IInterviewClient
    {
        private readonly HttpClient _httpClient;
        public InterviewClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<InterviewDTO> AddInterview(InterviewDTO interviewDTO)
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost:57892/api/Interview/Add"),
                Method = HttpMethod.Post,
                Content = HttpRequestExtensions.ContentAsByteJson(interviewDTO),
            };
            var response = await _httpClient.SendAsync(requestMessage);
            var result = HttpResponseExtensions.ContentAsType<InterviewDTO>(response);
            return result;
        }
    }
}
