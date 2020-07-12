using AutoMapper;
using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;
using FairWorks.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.Mapping
{
    public class StandTypeProfile : ProfileBase
    {
        public StandTypeProfile()
        {
            CreateMap<StandType, StandTypeDTO>().ReverseMap();
        }
    }
}
