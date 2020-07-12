using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class ContractTypeProfile : ProfileBase
    {
        public ContractTypeProfile()
        {
            CreateMap<ContractType, ContractTypeDTO>().ReverseMap();
        }
    }
}
