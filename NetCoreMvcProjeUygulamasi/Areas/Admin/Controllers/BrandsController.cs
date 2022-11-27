using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreMvcProjeUygulamasi.Data;

namespace NetCoreMvcProjeUygulamasi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandsController : Controller
    {
        DatabaseContext context = new DatabaseContext(); // DatabaseContext sınıfından context isminde bir nesne oluşturduk
        // GET: BrandsController
        public ActionResult Index()
        {
            var liste = context.Brands.ToList(); // context nesnesi içindeki Brands tablosu üzerinden 1 liste oluştur.
            return View(liste); // ekranda bizden beklenen marka listesini ekrana burada yolladık
        }

        // GET: BrandsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BrandsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BrandsController/Create
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
                return View();
            }
        }

        // GET: BrandsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BrandsController/Edit/5
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
                return View();
            }
        }

        // GET: BrandsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BrandsController/Delete/5
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
                return View();
            }
        }
    }
}
