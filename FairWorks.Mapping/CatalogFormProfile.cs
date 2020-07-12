using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    class CatalogFormProfile :ProfileBase
    {
        public CatalogFormProfile()
        {
            CreateMap<CatalogForm, CatalogFormDTO>().ReverseMap();
        }
    }
}
