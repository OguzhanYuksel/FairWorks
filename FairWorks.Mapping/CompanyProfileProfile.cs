//using CompanyProfile = FairWorks.Model.CompanyProfile;
using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
   public class CompanyProfileProfile : ProfileBase
    {
        public CompanyProfileProfile()
        {
            CreateMap<FairWorks.DAL.Entities.CompanyProfile, CompanyProfileDTO>().ReverseMap();
        }
    }
}
