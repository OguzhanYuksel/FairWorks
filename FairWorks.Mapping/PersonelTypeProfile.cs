using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class PersonelTypeProfile : ProfileBase
    {
        public PersonelTypeProfile()
        {
            CreateMap<PersonelType, PersonelTypeDTO>().ReverseMap();
        }
    }
}
