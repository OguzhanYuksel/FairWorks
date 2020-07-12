using System.Collections.Generic;

namespace FairWorks.DTO
{
    public class SalesPersonDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool isInternational { get; set; }
        public int Commission { get; set; }
        public List<InterviewDTO> Interviews { get; set; }
        public List<OfferDTO> Offers { get; set; }
        public List<ContractDTO> Contracts { get; set; }

    }
}