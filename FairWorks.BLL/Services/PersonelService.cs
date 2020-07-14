using FairWorks.Core.Services;
using FairWorks.DAL.Data.Repositories;
using FairWorks.DAL.Data.UnitOfWork;
using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.BLL.Services
{
    public class PersonelService : ServiceBase<Personel, PersonelDTO>, IPersonelService
    {
        private readonly IRepository<PersonelType> _personelTypeRepository;
        public PersonelService(IUnitofWork uow) : base(uow)
        {
            _personelTypeRepository = _uow.GetRepository<PersonelType>();
        }

        public async Task<List<PersonelTypeDTO>> GetAllPersonelTypesAsync()
        {
            var personelTypeList = await _personelTypeRepository.GetAll().ToListAsync();
            return MapperFactory.CurrentMapper.Map<List<PersonelTypeDTO>>(personelTypeList);
        }
        public async Task<PersonelTypeDTO> GetPersonelTypeAsync(Guid Id)
        {
            var personelType = await _personelTypeRepository.GetAsync(x => x.Id == Id);
            return MapperFactory.CurrentMapper.Map<PersonelTypeDTO>(personelType);
        }
    }
}
