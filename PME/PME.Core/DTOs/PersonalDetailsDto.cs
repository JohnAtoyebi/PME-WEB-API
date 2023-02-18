using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PME.Core.DTOs
{
    public class PersonalDetailsDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string ProgrammingLanguage { get; set; }
        public string Address { get; set; }
    }
}
