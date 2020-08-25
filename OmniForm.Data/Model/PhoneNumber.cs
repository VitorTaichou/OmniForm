using System.ComponentModel.DataAnnotations.Schema;

namespace OmniForm.Data.Model
{
    public class PhoneNumber
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Number { get; set; }
    }
}
