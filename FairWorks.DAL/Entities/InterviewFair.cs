using FairWorks.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DAL.Entities
{
    public class InterviewFair : Entity<Guid>
    {
        public Guid InterviewId { get; set; } 
        public virtual Interview Interview { get; set; }
        public Guid FairId { get; set; }
        public virtual Fair Fair { get; set; }
        public Guid CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}