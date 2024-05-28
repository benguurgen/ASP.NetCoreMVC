using Microsoft.AspNetCore.Mvc;

namespace Example07ActionResult.Controllers
{
    public class OtelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormCollection form)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
