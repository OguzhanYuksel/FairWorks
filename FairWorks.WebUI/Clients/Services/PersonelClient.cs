using FairWorks.DTO;
using FairWorks.WebUI.Clients.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Clients.Services
{
    public class PersonelClient : IPersonelClient
    {
        private readonly HttpClient _httpClient;
        public PersonelClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            //_httpClient.BaseAddress = new Uri("http://localhost:57892");
        }
        public async Task<PersonelDTO> AddPersonel(PersonelDTO personelDTO)
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost:57892/api/Personel/Add"),
                Method = HttpMethod.Post,
                Content = HttpRequestExtensions.ContentAsByteJson(personelDTO),
            };
            var response = await _httpClient.SendAsync(requestMessage);
            var result = HttpResponseExtensions.ContentAsType<PersonelDTO>(response);
            return result;
        }

        public async Task<List<PersonelTypeDTO>> GetAllPersonelTypes()
        {
            var response = await _httpClient.GetAsync("http://localhost:57892/api/Personel/GetAllPersonelTypes");
            var result = HttpResponseExtensions.ContentAsType<List<PersonelTypeDTO>>(response);
            return result;
        }
    }
}
