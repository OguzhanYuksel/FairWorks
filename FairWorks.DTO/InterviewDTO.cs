using System;
using System.Collections.Generic;

namespace FairWorks.DTO
{
    public class InterviewDTO
    {
        public SalesPersonDTO SalesPerson { get; set; }
        public DateTime InterviewDate { get; set; }
        public InterviewerDTO Interviewer { get; set; }
        public string Sectors { get; set; }
        public SalonDTO Salon { get; set; }
        public CompanyProfileDTO CompanyProfile { get; set; }
        public CompanyDTO Company { get; set; }
        public string Notes { get; set; }
        public List<InterviewFairDTO> InterviewFairs { get; set; }
    }
}