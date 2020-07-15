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
    public class SectorController : ControllerBase
    {
        private readonly ISectorService _sectorService;
        public SectorController(ISectorService sectorService)
        {
            _sectorService = sectorService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<SectorDTO>>> GetAll()
        {
            var sectorList = await _sectorService.GetAllAsync();
            return sectorList;
        }
    }
}