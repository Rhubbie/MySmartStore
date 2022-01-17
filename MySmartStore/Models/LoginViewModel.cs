using System.ComponentModel.DataAnnotations;

namespace MySmartStore.Models
{
    /// <summary>
    /// For the purposes of Login not with an 3rd party OAUTh
    /// </summary>
    public class LoginViewModel
    {
        [Key]
        public int Sn { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}