using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class InterviewerProfile : ProfileBase
    {
        public InterviewerProfile()
        {
            CreateMap<Interviewer, InterviewerDTO>().ReverseMap();
        }
    }
}
