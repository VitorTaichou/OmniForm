using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OmniForm.Models.Account
{
    public class CustomerUserViewModel
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "Nome Completo")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Required]
        [Display(Name = "RG")]
        public string Rg { get; set; }

        [Required]
        [Display(Name = "Sexo")]
        public char Sex { get; set; }

        [Required]
        [Display(Name = "Data de Nascimento")]
        public DateTime Birthday { get; set; }

        //Address Info
        [Required]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Required]
        [Display(Name = "Rua")]
        public string Street { get; set; }

        [Required]
        [Display(Name = "Número")]
        public string Number { get; set; }

        [Required]
        [Display(Name = "Bairro")]
        public string Neighborhood { get; set; }

        [Display(Name = "Complemento")]
        public string Complement { get; set; }

        [Required]
        [Display(Name = "Cidade")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public string State { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        public string PhoneNumber1 { get; set; }

        [Display(Name = "Telefone")]
        public string PhoneNumber2 { get; set; }

        //Login inf
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Falha na confirmação de senha, senhas não coincidem!")]
        [Display(Name = "Confirmação de Senha")]
        public string ConfirmPassword { get; set; }
    }
}
