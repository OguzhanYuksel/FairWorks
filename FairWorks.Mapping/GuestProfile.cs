using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class GuestProfile : ProfileBase
    {
        public GuestProfile()
        {
            CreateMap<Guest, GuestDTO>().ReverseMap();
        }
    }
}
