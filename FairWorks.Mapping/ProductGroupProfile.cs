using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class ProductGroupProfile : ProfileBase
    {
        public ProductGroupProfile()
        {
            CreateMap<ProductGroup, ProductGroupDTO>().ReverseMap();
        }
    }
}
