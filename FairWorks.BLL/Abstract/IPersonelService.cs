using FairWorks.Core.Services;
using FairWorks.DAL.Entities;
using FairWorks.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.BLL
{
    public interface IPersonelService : IServiceBase<Personel, PersonelDTO>
    {
        Task<List<PersonelTypeDTO>> GetAllPersonelTypesAsync();
        Task<PersonelTypeDTO> GetPersonelTypeAsync(Guid Id);
    }
}
