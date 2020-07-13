using System;

namespace FairWorks.DTO
{
    public class ContractDTO : BaseDTO
    {
        public DateTime ContractDate { get; set; }

        public SalesPersonDTO SalesPerson { get; set; }
        public InterviewerDTO Interviewer { get; set; }
        public  CompanyDTO Company { get; set; }
        public  ContractTypeDTO ContractType { get; set; }
        public StandDTO Stand { get; set; }
        public  SalonDTO Salon { get; set; }
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