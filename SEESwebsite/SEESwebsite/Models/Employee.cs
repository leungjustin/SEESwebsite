using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEESwebsite.Models
{
    public class Employee : IdentityUser
    {
        [NotMapped]
        public IList<string> RoleName { get; set; }    
        public string FirstEmployee { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string SSN { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmployeeStatus { get; set; }
    }
}
