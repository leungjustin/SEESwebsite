using System.ComponentModel.DataAnnotations;

namespace SEESwebsite.Models
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Please enter a first name")]
        [StringLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a last name")]
        [StringLength(100)]
        public string LastName { get; set; } = string.Empty;


        //this code for username, password, and confirm password from Murach book
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255)]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter an email address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a phone number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter an address")]
        [StringLength(254)] /* https://www.google.com/search?q=what+is+a+good+maximum+string+length+for+an+address&rlz=1C1CHBF_enUS877US878&oq=what+is+a+good+maximum+string+length+for+an+address&aqs=chrome..69i57j33i160l2.21034j0j7&sourceid=chrome&ie=UTF-8 */
        public string AddressLine1 { get; set; } = string.Empty;

        [StringLength(254)]
        public string AddressLine2 { get; set; } = string.Empty; //this line is optional

        [Required(ErrorMessage = "Please enter a city name")]
        [StringLength(35)]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please specify a two letter state code")]
        [StringLength(2)]
        public string State { get; set; } = string.Empty;

        


        //[Required(ErrorMessage ="Please enter a date of birth")]
        //[Range(DateTime, )]
        //public DateTime Dob {get; set}


        //public DateTime GetCurrentMinAge()
        //{
            //min age to work in oregon is 14
            //get the current year in DateTime format
            //DateTime currYear = DateTime.Now;


        //}
    }
}
