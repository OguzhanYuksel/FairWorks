using FairWorks.DTO;
using FairWorks.WebUI.Clients.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Clients.Services
{
    public class OfferClient : IOfferClient
    {
        private readonly HttpClient _httpClient;
        public OfferClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<OfferDTO>> GetAllOffers()
        {
            var response = await _httpClient.GetAsync("http://localhost:57892/api/Offer/GetAll");
            var result = HttpResponseExtensions.ContentAsType<List<OfferDTO>>(response);
            return result;
        }
    }
}
