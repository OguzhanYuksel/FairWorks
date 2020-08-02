using FairWorks.Core.Services;
using FairWorks.DAL.Data.UnitOfWork;
using FairWorks.DAL.Entities;
using FairWorks.DTO;

namespace FairWorks.BLL.Services
{
    public class CompanyService : ServiceBase<Company, CompanyDTO>,ICompanyService
    {
        public CompanyService(IUnitofWork uow) : base (uow)
        {
        }
    }
}