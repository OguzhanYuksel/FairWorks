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
    public class InterviewerService : ServiceBase<Interviewer, InterviewerDTO>, IInterviewerService
    {
        public InterviewerService(IUnitofWork uow) : base(uow)
        {
        }
        public async Task<InterviewerDTO> GetByNameAndEmailAsync(InterviewerDTO interviewerDTO)
        {
            var interviewer = MapperFactory.CurrentMapper.Map<InterviewerDTO>(await _repo.GetAsync(x => x.Name == interviewerDTO.Name && x.Email == interviewerDTO.Email));
            return interviewer;
        }
    }
}
