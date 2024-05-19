using Example05Models.Models;
using Example05Models.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example05Models.Controllers
{
    public class StudentController : Controller
    {

        private string _pageTitle = "Student ";
        private MenuService _menuService;
        
        public StudentController()
        {
            
            _menuService = new MenuService();
        }
        // GET: StudentController
        public ActionResult Index()
        {
            ViewBag.Menus = _menuService.GetMenus();
            ViewBag.Title = $"{_pageTitle} Index";
            ViewData["Baslık"]= "Öğrenciler";
            List<Student> student = StudentService.Students();

            return View(student);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Menus = _menuService.GetMenus();
            ViewBag.Title = $"{_pageTitle} Details";
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            ViewBag.Menus = _menuService.GetMenus();
            ViewBag.Title = $"{_pageTitle} Create";
            ViewData["Baslık"] = "Yeni Öğrenci";

            Student student = new Student();

            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.Menus = _menuService.GetMenus();
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Menus = _menuService.GetMenus();
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.Menus = _menuService.GetMenus();
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.Menus = _menuService.GetMenus();
                return View();
            }
        }
    }
}
