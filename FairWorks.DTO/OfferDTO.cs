using System;

namespace FairWorks.DTO
{
    public class OfferDTO
    {
        public DateTime OfferDate { get; set; }
        public SalonDTO Salon { get; set; }
        public  SalesPersonDTO SalesPerson { get; set; }
        public int OfferArea { get; set; }
        public int OfferUnitPrice { get; set; }
        public string ExchangeType { get; set; }
        public int ExchangeRate { get; set; }
        public int MaturityCount { get; set; }
        public string PaymentPlan { get; set; }
        public DateTime ExpireDate { get; set; }
        public CompanyDTO Company { get; set; }
    }
}