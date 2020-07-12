using System.Collections.Generic;

namespace FairWorks.DTO
{
    public class InterviewerDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string DirectPhone { get; set; }
        public string Email { get; set; }
        public CompanyDTO Company { get; set; }
        public List<InterviewDTO> Interviews { get; set; }
        public List<ContractDTO> Contracts { get; set; }
    }
}
