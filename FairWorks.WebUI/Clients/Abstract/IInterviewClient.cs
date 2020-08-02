using FairWorks.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Clients.Abstract
{
    public interface IInterviewClient
    {
        
        Task<List<InterviewDTO>> GetAllAsync();
        Task<string> AddInterview(InterviewDTO interviewDTO);
        Task<InterviewDTO> GetById(string Id);
        Task<string> UpdateAsync(InterviewDTO interviewDTO);
    }
}
