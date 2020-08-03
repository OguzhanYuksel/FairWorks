using FairWorks.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DAL.Entities
{
    public class Interviewer : Entity<Guid>
    {
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string DirectPhone { get; set; }
        public string Email { get; set; }
        public Guid CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Interview> Interviews { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
