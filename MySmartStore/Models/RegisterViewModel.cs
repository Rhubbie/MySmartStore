using System.ComponentModel.DataAnnotations;

namespace MySmartStore.Models
{
    /// <summary>
    /// For the purposes of registering with the store
    /// </summary>
    public class RegisterViewModel
    {
        [Key]
        public int Sn { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "The password and confirmation password do not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}