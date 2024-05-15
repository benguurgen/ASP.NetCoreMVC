using System.ComponentModel.DataAnnotations;

namespace Example03TagHelper.Models
{
    public class ContactForm
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool IsStudent { get; set; }
        
        [EmailAddress] //Data annotation
        public string Email { get; set; }
   
        [DataType(DataType.Password)]
        [MinLength(6)]
        [MaxLength(15)]
        public string Password { get; set; }
    }
}
