using FairWorks.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Clients.Abstract
{
    public interface IPersonelClient
    {
        Task<PersonelDTO> AddPersonel(PersonelDTO personelDTO);
        Task<List<PersonelTypeDTO>> GetAllPersonelTypes();
    }
}
