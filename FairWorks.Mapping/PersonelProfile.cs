using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
   public  class PersonelProfile : ProfileBase
    {
        public PersonelProfile()
        {
            CreateMap<Personel, PersonelDTO>().ReverseMap();
        }
    }
}
