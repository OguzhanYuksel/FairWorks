using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;
using FairWorks.Model;
using System;
using System.Collections.Generic;
using System.Text;

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
