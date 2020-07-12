using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class FairProfile : ProfileBase
    {
        public FairProfile()
        {
            CreateMap<Fair, FairDTO>().ReverseMap();
        }
    }
}
