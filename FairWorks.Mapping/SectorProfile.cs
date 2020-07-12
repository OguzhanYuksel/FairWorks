using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;
using FairWorks.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.Mapping
{
    public class SectorProfile : ProfileBase
    {
        public SectorProfile()
        {
            CreateMap<Sector, SectorDTO>().ReverseMap();
        }
    }
}
