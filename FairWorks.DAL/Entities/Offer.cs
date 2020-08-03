using FairWorks.DAL.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DAL.Entities
{
    public class Offer : Entity<Guid>
    {
        public DateTime OfferDate { get; set; }
        public Guid SalonId { get; set; }
        public virtual Salon Salon { get; set; }
        public Guid SalesPersonId { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
        public int OfferArea { get; set; }
        public int OfferUnitPrice { get; set; }
        public string ExchangeType { get; set; }
        public int ExchangeRate { get; set; }
        public int MaturityCount { get; set; }
        public string PaymentPlan { get; set; }
        public DateTime ExpireDate { get; set; }
        public Guid CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
