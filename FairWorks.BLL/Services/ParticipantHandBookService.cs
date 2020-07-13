using FairWorks.Core.Services;
using FairWorks.DAL.Data.UnitOfWork;
using FairWorks.DAL.Entities;
using FairWorks.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.BLL.Services
{
    public class ParticipantHandBookService : ServiceBase<ParticipantHandBook, ParticipantHandBookDTO>, IParticipantHandBookService
    {
        public ParticipantHandBookService(IUnitofWork uow) : base(uow)
        {
        }
    }
}
