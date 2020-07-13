using FairWorks.Core.Services;
using FairWorks.DAL.Data.UnitOfWork;
using FairWorks.DAL.Entities;
using FairWorks.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.BLL.Services
{
    public class StandService : ServiceBase<Stand, StandDTO>, IStandService
    {
        public StandService(IUnitofWork uow) : base(uow)
        {
        }
    }
}
