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

        [Required(ErrorMessage = "Campo <span class=\"font-weight-bold\">{0}</span> Obrigatório!")]
        [Display(Name = "Nome Completo")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Campo <span class=\"font-weight-bold\">{0}</span> Obrigatório!")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo <span class=\"font-weight-bold\">{0}</span> Obrigatório!")]
        [Display(Name = "RG")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "Campo <span class=\"font-weight-bold\">{0}</span> Obrigatório!")]
        [Display(Name = "Sexo")]
        public char Sex { get; set; }

        [Required(ErrorMessage = "Campo <span class=\"font-weight-bold\">{0}</span> Obrigatório!")]
        [Display(Name = "Data de Nascimento")]
        public DateTime Birthday { get; set; }

        //Address Info
        [Required(ErrorMessage = "Campo <span class=\"font-weight-bold\">{0}</span> Obrigatório!")]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Campo <span class=\"font-weight-bold\">{0}</span> Obrigatório!")]
        [Display(Name = "Rua")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Campo <span class=\"font-weight-bold\">{0}</span> Obrigatório!")]
        [Display(Name = "Número")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Campo <span class=\"font-weight-bold\">{0}</span> Obrigatório!")]
        [Display(Name = "Bairro")]
        public string Neighborhood { get; set; }

        [Display(Name = "Complemento")]
        public string Complement { get; set; }

        [Required(ErrorMessage = "Campo <span class=\"font-weight-bold\">{0}</span> Obrigatório!")]
        [Display(Name = "Cidade")]
        public string City { get; set; }

        [Required(ErrorMessage = "Campo <span class=\"font-weight-bold\">{0}</span> Obrigatório!")]
        [Display(Name = "Estado")]
        public string State { get; set; }

        [Required(ErrorMessage = "Campo <span class=\"font-weight-bold\">{0}</span> Obrigatório!")]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo <span class=\"font-weight-bold\">{0}</span> Obrigatório!")]
        [Display(Name = "Telefone Principal")]
        public string PhoneNumber1 { get; set; }

        [Display(Name = "Telefone Secundário")]
        public string PhoneNumber2 { get; set; }

        //Login inf
        [Required(ErrorMessage = "Campo <span class=\"font-weight-bold\">{0}</span> Obrigatório!")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "<span class=\"font-weight-bold\">Senhas não coincidem!</span>")]
        [Display(Name = "Confirmar")]
        public string ConfirmPassword { get; set; }
    }
}
