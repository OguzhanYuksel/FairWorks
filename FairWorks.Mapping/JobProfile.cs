using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class JobProfile : ProfileBase
    {
        public JobProfile()
        {
            CreateMap<Job, JobDTO>().ReverseMap();
        }
    }
}
