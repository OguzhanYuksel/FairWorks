using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FairWorks.BLL;
using FairWorks.DAL.Entities;
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
            var result =  await _fairService.GetActiveFairsWithSalons();
            return result;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<FairDTO>> Get(Guid id)
        {
            var fair = await _fairService.GetAsync(id);
            return fair;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<FairDTO>> Add(FairDTO fairDTO)
        {
            var fair = await _fairService.AddAsync(fairDTO);
            return fair;
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult<FairDTO>> Update(FairDTO fairDTO)
        {
            var personel = await _fairService.UpdateAsync(fairDTO);
            return personel;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<FairDTO>>> GetByName(string name)
        {
            var fairList = await _fairService.GetByNameListAsync(name);
            return fairList;
        }
    }
}