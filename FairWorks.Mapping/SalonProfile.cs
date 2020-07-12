using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class SalonProfile : ProfileBase
    {
        public SalonProfile()
        {
            CreateMap<Salon, SalonDTO>().ReverseMap();
        }
    }
}
