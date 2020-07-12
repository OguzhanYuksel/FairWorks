using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class CompanyProfile : ProfileBase
    {
        public CompanyProfile()
        {
            CreateMap<Company, CompanyDTO>().ReverseMap();
        }
    }
}
