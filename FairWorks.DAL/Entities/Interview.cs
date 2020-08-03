using FairWorks.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DAL.Entities
{
    public class Interview : Entity<Guid>
    {
        public Guid SalesPersonId { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
        public DateTime InterviewDate { get; set; }
        public Guid? InterviewerId { get; set; }
        public virtual Interviewer Interviewer { get; set; }
        public Guid? SectorId { get; set; }
        public Sector Sector { get; set; }
        public Guid SalonId { get; set; }
        public virtual Salon Salon { get; set; }
        public Guid CompanyProfileId { get; set; }
        public virtual CompanyProfile CompanyProfile { get; set; }
        public Guid CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public string Notes { get; set; }
        public virtual ICollection<InterviewFair> InterviewFairs { get; set; }
    }
}
