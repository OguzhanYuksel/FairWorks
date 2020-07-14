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
    public class PersonelController : ControllerBase
    {
        private readonly IPersonelService _personelService;
        public PersonelController(IPersonelService personelService)
        {
            _personelService = personelService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<PersonelDTO>> Get(Guid id)
        {
            var company = await _personelService.GetAsync(id);
            return company;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<PersonelDTO>>> GetAll()
        {
            var personelList = await _personelService.GetAllAsync();
            return personelList;
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<PersonelDTO>> Add(PersonelDTO personelDTO)
        {
            var personel = await _personelService.AddAsync(personelDTO);
            return personel;
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult<PersonelDTO>> Update(PersonelDTO personelDTO)
        {
            var personel = await _personelService.UpdateAsync(personelDTO);
            return personel;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<PersonelDTO>>> GetByName(string name)
        {
            var personelList = await _personelService.GetByNameAsync(name);
            return personelList;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<PersonelTypeDTO>>> GetAllPersonelTypes()
        {
            var result = await _personelService.GetAllPersonelTypesAsync();
            return result;
        }
    }
}