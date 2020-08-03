using FairWorks.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DAL.Entities
{
    public class CompanyProfile : Entity<Guid>
    {
        public ICollection<CompanyCompanyProfile> CompanyCompanyProfiles { get; set; }
    }
}
