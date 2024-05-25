using Example05Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Example05Models.Controllers
{
    public class TeacherController : Controller
    {
        private MenuService _menuService;

        public TeacherController()
        {
            _menuService = new MenuService();
        }
        public IActionResult Index()
        {
            ViewBag.Menus = _menuService.GetMenus();
            return View();
        }
    }
}
