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

            //ViewBag.KayitDeneme = ViewBag.Deneme ?? "ViewBag.Deneme gelemedi"; //Controllera gidemez
            //ViewData["KayitEkBilgi"] = ViewData["EkBilgi"] ?? "ViewData[\"KayittanGelenEkBilgi\"] gelemedi"; //Controllera gidemez

            //string tempData = "TempData[\"KayıtDurumu\"] henüz gönderilmedi";

            //if (TempData["KayitDurumu"] != null)
            //{
            //    tempData = TempData["KayitDurumu"].ToString() ; // Controllera gelir.
            //}

            //ViewBag.KayitTempData= tempData ;

            List<Student> students = StudentService.Students();
            return View(students);
                
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
        public ActionResult Create(Student student)
          {
            try
            {

                //ViewBag.Deneme = "view bag geldin mi";
                //ViewData["EkBilgi"] = "View Data geldin mi";
                //TempData["KayitDurumu"] = "Kayıt başarılı oldu";

                //string name = collection["Name"];
                //string surname = collection[";Surname"];
                //string email = collection["Email"];
                //string birthDate = collection["BirthDate"];
                //string gender = collection["Gender"];
                //string status = collection["StudentStatus"];


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
