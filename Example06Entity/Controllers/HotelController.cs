using Example06Entity.Data;
using Example06Entity.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Example06Entity.Controllers
{
    public class HotelController : Controller
    {
        private AppDbContext _appDbContext;
        private ILogger<HotelController> _logger;
        public HotelController(AppDbContext appDbContect, ILogger<HotelController> logger)
        {
            _appDbContext = appDbContect;
            _logger = logger;
        }

        // GET: HotelController
        public ActionResult Index()
        {
            var oteller = _appDbContext.Otels.ToList();
            _logger.LogInformation("Oteller sayfası listeleniyor.. Toplam otel sayısı: "+oteller.Count);
            _logger.LogError("Oteller sayfası listeleniyor.. Toplam otel sayısı: "+oteller.Count);
            _logger.LogWarning("Oteller sayfası listeleniyor.. Toplam otel sayısı: "+oteller.Count);
            _logger.LogCritical("Oteller sayfası listeleniyor.. Toplam otel sayısı: "+oteller.Count);
            return View(oteller);
        }

        // GET: HotelController/Details/5
        public ActionResult Details(int id)
        {
            Otel model = _appDbContext.Otels.Single(o => o.Id == id);
            


            return View(model);
        }

        // GET: HotelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HotelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Otel model)
        {
            try
            {
                _appDbContext.Otels.Add(model);
                _appDbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HotelController/Edit/5
        public ActionResult Edit(int id)
        {
            Otel model = _appDbContext.Otels.Single(o => o.Id == id);
            return View(model);
        }

        // POST: HotelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Otel newModel)
        {
            try
            {
                Otel oldmodel = _appDbContext.Otels.Single(o => o.Id == id);
                oldmodel.Name = newModel.Name;
                oldmodel.Description = newModel.Description;
                oldmodel.Phone= newModel.Phone;

                _appDbContext.Otels.Update(oldmodel);
                _appDbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HotelController/Delete/5
        public ActionResult Delete(int id)
        {
            Otel model = _appDbContext.Otels.Single(o => o.Id == id);
            return View(model);
        }

        // POST: HotelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
               Otel model = _appDbContext.Otels.Single(o => o.Id == id);
                _appDbContext.Otels.Remove(model);
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
      
        public ActionResult DeleteConfirm2(int id)
        {
            try
            {
                Otel model = _appDbContext.Otels.Single(o => o.Id == id);
                _appDbContext.Otels.Remove(model);
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
