using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class StandTypeProfile : ProfileBase
    {
        public StandTypeProfile()
        {
            CreateMap<StandType, StandTypeDTO>().ReverseMap();
        }
    }
}
