using Example05Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Example05Models.Controllers
{
    public class HomeController : Controller
    {
        private string _pageTitle = "Home ";
        private MenuService _menuService;
        public HomeController()
        {
            _menuService = new MenuService();
        }
        public IActionResult Index()
        {
            ViewBag.Menus = _menuService.GetMenus();

            ViewBag.Title = $"{_pageTitle} Index";
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Menus = _menuService.GetMenus();
            ViewBag.Title = $"{_pageTitle} About";
            return View();
        }
    }
}
