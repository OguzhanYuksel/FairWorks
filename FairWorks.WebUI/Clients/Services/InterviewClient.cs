using FairWorks.DTO;
using FairWorks.WebUI.Clients.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public async Task<List<InterviewDTO>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("http://localhost:57892/api/Interview/GetAll");
            var result = HttpResponseExtensions.ContentAsType<List<InterviewDTO>>(response);
            return result;
        }

        public async Task<InterviewDTO> GetById(string Id)
        {
            var response = await _httpClient.GetAsync("http://localhost:57892/api/Interview/GetById?Id=" + Id);
            var result = HttpResponseExtensions.ContentAsType<InterviewDTO>(response);
            return result;
        }

        public async Task<string> AddInterview(InterviewDTO interviewDTO)
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost:57892/api/Interview/Add"),
                Method = HttpMethod.Post,
                Content = HttpRequestExtensions.ContentAsByteJson(interviewDTO),
            };
            var response = await _httpClient.SendAsync(requestMessage);
            if (response.StatusCode == HttpStatusCode.OK)
                return await Task.FromResult("Görüşme Kaydedildi.");
            return await Task.FromResult("Görüşme kaydedilemedi.");
        }

        public async Task<string> UpdateAsync(InterviewDTO interviewDTO)
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost:57892/api/Interview/Update"),
                Method = HttpMethod.Post,
                Content = HttpRequestExtensions.ContentAsByteJson(interviewDTO),
            };
            var response = await _httpClient.SendAsync(requestMessage);
            if (response.StatusCode == HttpStatusCode.OK)
                return await Task.FromResult("Görüşme Güncellendi.");
            return await Task.FromResult("Görüşme Güncellenemedi.");
        }
    }
}
