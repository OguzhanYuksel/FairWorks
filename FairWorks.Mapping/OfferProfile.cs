using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class OfferProfile : ProfileBase
    {
        public OfferProfile()
        {
            CreateMap<Offer, OfferDTO>().ReverseMap();
        }
    }
}
