using Example04Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace Example04Controllers.Controllers
{
    //[Route("Admin/{controller}")]
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Menuler = GetMenus();
            ViewBag.AltMenuler = GetSubMenus();
            return View();
        }
        public IActionResult Contact()
        {
            ViewBag.Menuler = GetMenus();
            ViewBag.AltMenuler = GetSubMenus();
            return View();
        }
        #region Modelden veri alma
        [HttpPost]
        public IActionResult SaveMessage([Bind("Adi","Soyadi")]Contact contactMessage) // Bind kulladığımızda sadece adi ve soyadi gelecek
        {
            ViewBag.Menuler = GetMenus();
            ViewBag.AltMenuler = GetSubMenus();

            ViewBag.Name = contactMessage.Adi;
            ViewBag.Surname = contactMessage.Soyadi;
            ViewBag.Message = contactMessage.Mesaj;
            return View();

        }
        #endregion
        #region IFormCollection ile veri alma
        //[HttpPost]
        //public IActionResult SaveMessage(IFormCollection form) 
        //{

        //    ViewBag.Menuler = GetMenus();
        //    ViewBag.AltMenuler = GetSubMenus();
        //    string adi = form["Adi"];
        //    string soyadi = form["Soyadi"];
        //    string mesaj = form["Mesaj"];
        //    ViewBag.Name = adi;
        //    ViewBag.Surname = soyadi;
        //    ViewBag.Message = mesaj;
        //    return View();

        //}
        #endregion
        #region Parametresiz SaveMessage()
        //[HttpPost]
        //public IActionResult SaveMessage() // parametresiz form verilerini saklama HttpContext.Request.Form dan okunur.
        //{
        //    var request = HttpContext.Request;
        //    var form = HttpContext.Request.Form;
        //    var query = HttpContext.Request.Query;
        //    var route = HttpContext.Request.RouteValues;

        //    return View();

        //}
        #endregion
        #region Http Request ile veri alma
        //[HttpPost]
        //public IActionResult SaveMessage() // View kullandık
        //{

        //    ViewBag.Menuler = GetMenus();
        //    ViewBag.AltMenuler = GetSubMenus();
        //    IFormCollection form = HttpContext.Request.Form;
        //    string adi = form["Adi"];
        //    string soyadi = form["Soyadi"];
        //    string mesaj = form["Mesaj"];
        //    ViewBag.Name= adi;
        //    ViewBag.Surname = soyadi;
        //    ViewBag.Message = mesaj;

        //    return View();
        //}
        #endregion
        #region Parametre vererek veri alma
        //[HttpPost]
        //public IActionResult SaveMessage(string adi, string soyadi, string mesaj)
        //{
        //    ViewBag.Menuler = GetMenus();
        //    ViewBag.AltMenuler = GetSubMenus();

        //    ViewBag.Name = adi;
        //    ViewBag.Surname = soyadi;
        //    ViewBag.Message = mesaj;    
        //    return View();
        //}
        #endregion

        private List<Menu> GetMenus()
        {
            List<Menu> menus = new List<Menu>();

            Menu menu1 = new Menu() { Id = 1, DisplayName = "Anasayfa", Controller = "Home", Action = "Index" };
            Menu menu2 = new Menu() { Id = 2, DisplayName = "Hakkımızda", Controller = "About", Action = "Index" };
            Menu menu3 = new Menu() { Id = 3, DisplayName = "Projeler", Controller = "Project", Action = "Index" };
            Menu menu4 = new Menu() { Id = 4, DisplayName = "İletişim", Controller = "Contact", Action = "Index" };

            menus.Add(menu1);
            menus.Add(menu2);
            menus.Add(menu3);
            menus.Add(menu4);

            return menus;
        }

        private List<Menu> GetSubMenus()
        {
            List<Menu> menus = new List<Menu>();

            Menu menu1 = new Menu() { Id = 1, DisplayName = "Bize Ulaşın", Controller = "Contact", Action = "BizeUlasin" };
            Menu menu2 = new Menu() { Id = 2, DisplayName = "Şikayet Öneri", Controller = "Contact", Action = "SikayetOneri" };
            Menu menu3 = new Menu() { Id = 3, DisplayName = "İş Başvurusu", Controller = "Contact", Action = "IsBasvurusu" };

            menus.Add(menu1);
            menus.Add(menu2);
            menus.Add(menu3);

            return menus;
        }
    }
}
