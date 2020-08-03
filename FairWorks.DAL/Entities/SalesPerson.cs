using FairWorks.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DAL.Entities
{
    public class SalesPerson : Entity<Guid>
    {
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool isInternational { get; set; }
        public int Commission { get; set; }
        public virtual ICollection<Interview> Interviews { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
