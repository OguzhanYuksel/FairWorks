﻿using System;
using System.Collections.Generic;

namespace FairWorks.DTO
{
    public class InterviewDTO : BaseDTO
    {
        public SalesPersonDTO SalesPerson { get; set; }
        public DateTime InterviewDate { get; set; }
        public InterviewerDTO Interviewer { get; set; }
        public SectorDTO Sector { get; set; }
        public SalonDTO Salon { get; set; }
        public string SalonId { get; set; }
        public CompanyProfileDTO CompanyProfile { get; set; }
        public CompanyDTO Company { get; set; }
        public string Notes { get; set; }
        public List<InterviewFairDTO> InterviewFairs { get; set; }
        public List<string> FairIds { get; set; }
        public List<FairDTO> Fairs { get; set; }
    }
}