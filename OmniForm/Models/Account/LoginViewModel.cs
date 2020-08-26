using System.ComponentModel.DataAnnotations;

namespace OmniForm.Models.Account
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "E-mail")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Display(Name = "Manter Conectado")]
        public bool RememberMe { get; set; }
    }
}
