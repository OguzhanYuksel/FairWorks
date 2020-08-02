using FairWorks.Core.Services;
using FairWorks.DAL.Entities;
using FairWorks.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.BLL
{
    public interface IFairService : IServiceBase<Fair, FairDTO>
    {
        Task<List<FairDTO>> GetActiveFairsWithSalons();
    }
}
