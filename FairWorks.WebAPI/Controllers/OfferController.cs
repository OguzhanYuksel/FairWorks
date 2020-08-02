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
    public class OfferController : ControllerBase
    {
        private readonly IOfferService _offerService;
        public OfferController(IOfferService offerService)
        {
            _offerService = offerService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<OfferDTO>> Get(Guid id)
        {
            var offer = await _offerService.GetAsync(id);
            return offer;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<OfferDTO>>> GetAll()
        {
            var offerList = await _offerService.GetAllAsync();
            return offerList;
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<OfferDTO>> Add(OfferDTO offerDTO)
        {
            var offer = await _offerService.AddAsync(offerDTO);
            return offer;
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult<OfferDTO>> Update(OfferDTO offerDTO)
        {
            var offer = await _offerService.UpdateAsync(offerDTO);
            return offer;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<OfferDTO>>> GetByName(string name)
        {
            var offerList = await _offerService.GetByNameListAsync(name);
            return offerList;
        }

        [HttpDelete]
        [Route("[action]")]
        public async Task<ActionResult<bool>> Delete(Guid id)
        {
            var result = await _offerService.DeleteAsync(id);
            if (result)
                return Ok("Offer is deleted");
            return BadRequest("Offer not found");
        }
    }
}