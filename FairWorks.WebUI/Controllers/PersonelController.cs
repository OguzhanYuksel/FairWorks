using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FairWorks.DTO;
using FairWorks.WebUI.Clients.Abstract;
using FairWorks.WebUI.Models.Personel;
using Microsoft.AspNetCore.Mvc;

namespace FairWorks.WebUI.Controllers
{
    public class PersonelController : Controller
    {
        private readonly IPersonelClient _personelClient;
        public PersonelController(IPersonelClient personelClient)
        {
            _personelClient = personelClient;
        }
        [HttpGet]
        public async Task<ActionResult> AddPersonel()
        {
            var personelTypeDtos = await _personelClient.GetAllPersonelTypes();
            AddPersonelViewModel vm = new AddPersonelViewModel()
            {
                PersonelTypes = personelTypeDtos
            };
            return View(vm);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPersonel(PersonelDTO personelDTO)
        {
            personelDTO.PersonelType = new PersonelTypeDTO() { Id = Guid.Parse(personelDTO.PersonelTypeId)};
            var personel = _personelClient.AddPersonel(personelDTO);
            return Ok();
        }
    }
}