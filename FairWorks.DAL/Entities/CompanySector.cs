using FairWorks.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DAL.Entities
{
    public class CompanySector : Entity<Guid>
    {
        public Guid CompanyId { get; set; }
        public virtual Company Company{ get; set; }
        public Guid SectorId { get; set; }
        public virtual Sector Sector { get; set; }
    }
}
