using FairWorks.Core.Services;
using FairWorks.DAL.Entities;
using FairWorks.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.BLL
{
    public interface IInterviewService : IServiceBase<Interview, InterviewDTO>
    {
        Task<List<InterviewDTO>> GetAllWithIncludesAsync();
        Task<InterviewDTO> GetAllWithIncludesAsyncById(Guid Id);
    }
}
