namespace FairWorks.DTO
{
    public class StandDTO
    {
        public string Code { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Area { get; set; }
        public StandTypeDTO StandType { get; set; }
        public SalonDTO Salon { get; set; }
        public CompanyDTO Company { get; set; }
        public ContractDTO Contract { get; set; }
    }
}