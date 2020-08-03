using FairWorks.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DAL.Entities
{
    public class Contract : Entity<Guid>
    {
        public DateTime ContractDate { get; set; }
        public Guid SalesPersonId { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
        public Guid InterviewerId { get; set; }
        public virtual Interviewer Interviewer { get; set; }
        public Guid CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public Guid ContractTypeId { get; set; }
        public virtual ContractType ContractType { get; set; }
        public Guid StandId { get; set; }
        public virtual Stand Stand { get; set; }
        public Guid SalonId { get; set; }
        public virtual Salon Salon { get; set; }
        public int AreaUnitPrice { get; set; }
        public string ExchangeType { get; set; }
        public int ExchangeRate { get; set; }
        public int DiscountRate { get; set; }
        public int MaturityCount { get; set; }
        public string PaymentPlan { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool isSold { get; set; }
    }
}
