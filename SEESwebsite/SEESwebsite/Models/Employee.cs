using Microsoft.AspNetCore.Identity;

namespace SEESwebsite.Models
{
    public class Employee : IdentityUser
    {
        public IList<string> RoleName { get; set; }    
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string SSN { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmployeeStatis { get; set; }
    }
}
