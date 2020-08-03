using FairWorks.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DAL.Entities
{
    public class CompanyCompanyProfile : Entity<Guid>
    {
        public Guid CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public Guid CompanyProfileId { get; set; }
        public virtual CompanyProfile CompanyProfile { get; set; }
    }
}
