using Example03TagHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Example03TagHelper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            // 7 Şimdi view oluşturuyoruz
        }
        public IActionResult About()
        {
            return View();
           
        }
        public IActionResult Contact()
        {
            ContactForm form = new ContactForm();

            return View("ContactTagHelper", form);

        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Contact(ContactForm form)
        {
            bool isValid = ModelState.IsValid;
            //Bir işlem yapılacak/veri tabanına kayıt vb aksiyonlar alınır. Viewe ihtiyacı yoktur.

            // 1.Aynı controllerda başka actiona yönlendirme yapabiliriz.
            // 2.Farklı Controllerda bir actiona yönlendirme yapabiliriz.
            // 3. Aynı action için aynı viewe geri dönebiliriz.

            //string mesaj = $"{ad} {soyad} mesajınız ilgili birime ulaşmıştır.";

            //return View(model: mesaj);
            // return View("Contact", mesaj);
            //return View("ContactTagHelper", mesaj);
            return RedirectToAction("Index");
        }
    }
}
