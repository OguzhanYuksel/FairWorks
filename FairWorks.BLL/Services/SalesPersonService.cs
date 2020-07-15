using FairWorks.Core.Services;
using FairWorks.DAL.Data.UnitOfWork;
using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.BLL.Services
{
    public class SalesPersonService : ServiceBase<SalesPerson, SalesPersonDTO>, ISalesPersonService
    {
        public SalesPersonService(IUnitofWork uow) : base(uow)
        {
        }

        public async Task<SalesPersonDTO> GetByNameAndEmailAsync(SalesPersonDTO salesPersonDTO)
        {
            var salesPerson = MapperFactory.CurrentMapper.Map<SalesPersonDTO>(await _repo.GetAsync(x => x.Name == salesPersonDTO.Name && x.Email == salesPersonDTO.Email));
            return salesPerson;
        }
    }
}
