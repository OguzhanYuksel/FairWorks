//using CompanyProfile = FairWorks.Model.CompanyProfile;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
   public class CompanyProfileProfile : ProfileBase
    {
        public CompanyProfileProfile()
        {
            CreateMap<FairWorks.Model.CompanyProfile, CompanyProfileDTO>().ReverseMap();
        }
    }
}
