using System.ComponentModel.DataAnnotations;

namespace MyCompany.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Login")]
        public string UserName { get; set; }

        [Required]
        [UIHint("password")]
        [Display(Name = "Parola")]
        public string Password { get; set; }

        [Display(Name = "Memoreazama?")]
        public bool RememberMe { get; set; }
    }
}
