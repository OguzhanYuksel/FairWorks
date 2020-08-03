using FairWorks.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DAL.Entities
{
    public class Sector : Entity<Guid>
    {
        public virtual ICollection<CompanySector> CompanySectors { get; set; }
    }
}