using FairWorks.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DAL.Entities
{
    public class ProductGroup : Entity<Guid>
    {
        public string Code { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}