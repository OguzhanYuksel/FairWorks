using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;
using FairWorks.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.Mapping
{
    public class CompanyCompanyProfileProfile : ProfileBase
    {
        public CompanyCompanyProfileProfile()
        {
            CreateMap<CompanyCompanyProfile, CompanyCompanyProfileDTO>().ReverseMap();

        }
    }
}
