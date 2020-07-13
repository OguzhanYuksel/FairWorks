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
    public class StandTypeService : ServiceBase<StandType, StandTypeDTO>, IStandTypeService
    {
        public StandTypeService(IUnitofWork uow) : base(uow)
        {
        }
    }
}
