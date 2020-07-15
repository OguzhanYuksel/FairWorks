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
    public class FairController : ControllerBase
    {
        private readonly IFairService _fairService;
        public FairController(IFairService fairService)
        {
            _fairService = fairService;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<FairDTO>>> GetAll()
        {
            var companyList = await _fairService.GetAllAsync();
            return companyList.Where(f => f.Active).ToList();
        }
    }
}