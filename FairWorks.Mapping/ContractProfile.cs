using FairWorks.DAL.Entities;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;

namespace FairWorks.Mapping
{
    public class ContractProfile : ProfileBase
    {
        public ContractProfile()
        {
            CreateMap<Contract, ContractDTO>().ReverseMap();
        }
    }
}
