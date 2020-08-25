using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OmniForm.Data.Model
{
    public class CustomerUser : IdentityUser
    {
        //Personal Info
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string FullName { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public char Sex { get; set; }
        public DateTime Birthday { get; set; }

        //Address Info
        public string Cep { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string Complement { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        //Contact Info
        public virtual IEnumerable<PhoneNumber> PhoneNumbers { get; set; }

    }
}
