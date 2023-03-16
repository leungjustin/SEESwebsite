using System.ComponentModel.DataAnnotations;

namespace SEESwebsite.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Please enter an email address")]
        [StringLength(320)]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; } = string.Empty;

        [Required(ErrorMessage ="Please enter a password")]
        [StringLength (255)]
        [DataType(DataType.Password)] //displays password in non-readable format
        public string Password { get; set; } = string.Empty;
        public string ReturnUrl { get; set; } = string.Empty;
        public bool RememberMe { get; set; }
    }
}
