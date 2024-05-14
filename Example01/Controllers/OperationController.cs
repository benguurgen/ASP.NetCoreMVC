using Microsoft.AspNetCore.Mvc;

namespace Example01.Controllers
{
    public class OperationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Renkler()
        {
            return View();
        }
        public string GetPerson(int id, int test)
        {
            return "Sonuc:" + id;
            //https://localhost:7106/Operation/GetPerson/5 yazdıgımızda id = 5 atar.
            //https://localhost:7106/Operation/GetPerson/5?test=123 yazdığımızda test = 123 atar
        }
    }
}
