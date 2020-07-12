using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class SalesPersonProfile : ProfileBase
    {
        public SalesPersonProfile()
        {
            CreateMap<SalesPerson, SalesPersonDTO>().ReverseMap();
        }
    }
}
