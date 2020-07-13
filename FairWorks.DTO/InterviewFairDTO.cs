namespace FairWorks.DTO
{
    public class InterviewFairDTO : BaseDTO
    {
        public InterviewDTO Interview { get; set; }
        public FairDTO Fair { get; set; }
        public CompanyDTO Company { get; set; }
    }
}