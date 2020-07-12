using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class InterviewProfile : ProfileBase
    {
        public InterviewProfile()
        {
            CreateMap<Interview, InterviewDTO>().ReverseMap();
        }
    }
}
