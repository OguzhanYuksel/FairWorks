using FairWorks.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DAL.Entities
{
    public class Product : Entity<Guid>
    {
        public int Price { get; set; }
        public Guid ProductGroupId { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual Guid CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}