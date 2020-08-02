using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FairWorks.WebUI.Clients.Abstract;
using FairWorks.WebUI.Models.Offer;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.WebUI.Controllers
{
    public class OfferController : Controller
    {
        private readonly IOfferClient _offerClient;
        private readonly ICompanyClient _companyClient;
        public OfferController(IOfferClient offerClient,ICompanyClient companyClient)
        {
            _offerClient = offerClient;
            _companyClient = companyClient;
        }
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var offerList = await _offerClient.GetAllOffers();
            var companyList = await _companyClient.GetAllCompanies();
            OfferViewModel vm = new OfferViewModel()
            {
                Offers = offerList,
                Companies = companyList
            };
            return View(vm);
        }
    }
}