using System;
using System.Collections.Generic;
using System.Text;

namespace FairWorks.DTO
{
    public class GuestDTO
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public JobDTO Job { get; set; }
    }
}
