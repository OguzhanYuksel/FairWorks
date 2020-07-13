using System;
using System.Collections.Generic;

namespace FairWorks.DTO
{
    public class FairDTO : BaseDTO
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Active { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public List<SalonDTO> Salons { get; set; }
        public List<ProductGroupDTO> ProductGroups { get; set; }
        public List<InterviewFairDTO> InterviewFairs { get; set; }
    }
}