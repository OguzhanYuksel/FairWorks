using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class InterviewFairProfile : ProfileBase
    {
        public InterviewFairProfile()
        {
            CreateMap<InterviewFair, InterviewFairDTO>().ReverseMap();
        }
    }
}
