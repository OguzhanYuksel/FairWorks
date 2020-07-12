using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class CompanyCompanyProfileProfile : ProfileBase
    {
        public CompanyCompanyProfileProfile()
        {
            CreateMap<CompanyCompanyProfile, CompanyCompanyProfileDTO>().ReverseMap();

        }
    }
}
