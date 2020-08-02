using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FairWorks.BLL;
using FairWorks.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        private readonly ICompanyProfileService _companyProfileService;
        public CompanyController(ICompanyService companyService, ICompanyProfileService companyProfileService,ISectorService sectorService)
        {
            _companyService = companyService;
            _companyProfileService = companyProfileService;

        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<CompanyDTO>> Get(Guid id)
        {
           var company = await _companyService.GetAsync(id);
           return company;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<CompanyDTO>>> GetAll()
        {
            var companyList = await _companyService.GetAllAsync();
            return companyList;
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<CompanyDTO>> Add(CompanyDTO companyDTO)
        {
            var company = await _companyService.AddAsync(companyDTO);
            return company;
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult<CompanyDTO>> Update(CompanyDTO companyDTO)
        {
            var company = await _companyService.UpdateAsync(companyDTO);
            return company;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<CompanyDTO>>> GetByName(string name)
        {
            var companyList = await _companyService.GetByNameListAsync(name);
            return companyList;
        }

        [HttpDelete]
        [Route("[action]")]
        public async Task<ActionResult<bool>> Delete(Guid id)
        {
            var result = await _companyService.DeleteAsync(id);
            if (result)
                return Ok("Company is deleted");
            return BadRequest("Company not found");
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<CompanyProfileDTO>>> GetCompanyProfiles()
        {
            var companyList = await _companyProfileService.GetAllAsync();
            return companyList;
        }
    }
}