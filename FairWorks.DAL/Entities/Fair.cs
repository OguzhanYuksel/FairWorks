using FairWorks.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DAL.Entities
{
    public class Fair : Entity<Guid>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Active { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public virtual ICollection<Salon> Salons { get; set; }
        public virtual ICollection<ProductGroup> ProductGroups { get; set; }
        public virtual ICollection<InterviewFair> InterviewFairs { get; set; }
    }
}
