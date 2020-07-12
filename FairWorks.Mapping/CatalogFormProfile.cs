using FairWorks.DTO;
using FairWorks.Mapping.ConfigProfile;
using FairWorks.Model;
using System;
using System.Collections.Generic;
using System.Text;

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
