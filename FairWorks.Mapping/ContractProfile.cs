using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;
using FairWorks.Model;
using System;
using System.Collections.Generic;
using System.Text;

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
