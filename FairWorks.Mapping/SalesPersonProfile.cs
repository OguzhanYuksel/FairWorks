using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;
using FairWorks.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.Mapping
{
    public class SalesPersonProfile : ProfileBase
    {
        public SalesPersonProfile()
        {
            CreateMap<SalesPerson, SalesPersonDTO>().ReverseMap();
        }
    }
}
