using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class StandProfile : ProfileBase
    {
        public StandProfile()
        {
            CreateMap<Stand, StandDTO>().ReverseMap();
        }
    }
}
