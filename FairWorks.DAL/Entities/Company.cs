using FairWorks.DAL.BaseEntities;
using System;
using System.Collections.Generic;

namespace FairWorks.DAL.Entities
{
    public class Company : Entity<Guid>
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Fax { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
        public virtual ICollection<CompanyCompanyProfile> CompanyCompanyProfiles { get; set; }
        public virtual ICollection<CompanySector> CompanySectors { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
