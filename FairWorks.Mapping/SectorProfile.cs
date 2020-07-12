using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class SectorProfile : ProfileBase
    {
        public SectorProfile()
        {
            CreateMap<Sector, SectorDTO>().ReverseMap();
        }
    }
}
