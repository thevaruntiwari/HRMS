using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.App.Model
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public int Age { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string EmergencyContact { get; set; }
    }
}
