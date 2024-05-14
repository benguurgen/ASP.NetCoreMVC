using Microsoft.AspNetCore.Mvc;

namespace Example01.Controllers
{
    public class HomeController : Controller // Controllerdan miras almalı, isimler çakışmaması için Controller adı kullanmamalıyız. 
    {
        public IActionResult Index()
        {
            return View();
            //eğer return View kullanacaksak controller için view oluşturmamız gerekir.
        }
        public IActionResult About()
        {
            return View();
            
        }
    }
}
