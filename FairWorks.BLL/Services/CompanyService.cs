using FairWorks.Core.Services;
using FairWorks.DAL.Data.Repositories;
using FairWorks.DAL.Data.UnitOfWork;
using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FairWorks.BLL.Services
{
    public class CompanyService : ServiceBase<Company, CompanyDTO>,ICompanyService
    {
        public CompanyService(IUnitofWork uow) : base (uow)
        {
        }
    }
}