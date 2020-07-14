using System;

namespace FairWorks.DTO
{
    public class PersonelDTO : BaseDTO
    {
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PersonelTypeId { get; set; }
        public PersonelTypeDTO PersonelType { get; set; }
    }
}