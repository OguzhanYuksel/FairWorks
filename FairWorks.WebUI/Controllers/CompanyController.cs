using FairWorks.DTO;
using FairWorks.WebUI.Clients.Abstract;
using FairWorks.WebUI.Models.Company;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyClient _companyClient;
        private readonly ISectorClient _sectorClient;
        public CompanyController(ICompanyClient companyClient, ISectorClient sectorClient)
        {
            _companyClient = companyClient;
            _sectorClient = sectorClient;
        }
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var companyList = await _companyClient.GetAllCompanies();
            var companyProfileList = await _companyClient.GetAllCompanyProfiles();
            var sectorList = await _sectorClient.GetAllAsync();
            CompanyViewModel vm = new CompanyViewModel()
            {
                Companies = companyList,
                CompanyProfiles = companyProfileList,
                Sectors = sectorList
            };
            return View(vm);
        }

        [HttpGet]
        public IActionResult GetAll()
            {
                return View();
            }

        [HttpPost]
        public IActionResult AddCompany(CompanyDTO companyDTO)
        {
            var company = _companyClient.AddCompany(companyDTO);
            return Ok(company);
        }
    }
}
