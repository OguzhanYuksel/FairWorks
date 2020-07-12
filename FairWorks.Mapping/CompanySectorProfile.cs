using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class CompanySectorProfile : ProfileBase 
    {
        public CompanySectorProfile()
        {
            CreateMap<CompanySector, CompanySectorDTO>().ReverseMap();
        }
    }
}
