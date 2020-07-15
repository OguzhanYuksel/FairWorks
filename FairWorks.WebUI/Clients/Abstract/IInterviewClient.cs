using FairWorks.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FairWorks.WebUI.Clients.Abstract
{
    public interface IInterviewClient
    {
        Task<InterviewDTO> AddInterview(InterviewDTO interviewDTO);
    }
}
