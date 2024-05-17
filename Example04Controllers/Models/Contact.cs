using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Example04Controllers.Models
{
    public class Contact
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        [BindNever] //BindNever kullandıgımızda bu field formda gönderildiğinde null olarak alır.
        public string Mesaj { get; set; }
    }
}
