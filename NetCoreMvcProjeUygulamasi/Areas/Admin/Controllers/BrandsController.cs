using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreMvcProjeUygulamasi.Data;
using NetCoreMvcProjeUygulamasi.Entities;

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
        public ActionResult Create(Brand brand)
        {
            if (ModelState.IsValid) // Modelimizdeki validasyon kurallarına uyulmuşsa
            {
                try
                {
                    context.Brands.Add(brand); // entity frameworkde kayıt ekleme metodu Add dir. Parametre olarak markayı gönderdiğimizde ekleme gerçekleşir.
                    context.SaveChanges(); // Eklenen kaydı veritabanına işlenmesi için bu kod gerekli
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception hata)
                {
                    ModelState.AddModelError("", "Hata Oluştu!"); // Validasyon kontrol 
                }
            }
            
            return View(brand);
        }

        // GET: BrandsController/Edit/5
        public ActionResult Edit(int id)
        {
            var marka = context.Brands.Find(id); // Find metodu Ef ün id ye göre veritabanından ilgili kaydı bulup bize getiren metodudur.

            return View(marka);
        }

        // POST: BrandsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Brand brand)
        {
            try
            {
                context.Brands.Update(brand); // javascript confirm
                context.SaveChanges();
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
            var marka = context.Brands.Find(id);

            return View(marka);
        }

        // POST: BrandsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Brand brand)
        {
            try
            {
                context.Brands.Remove(brand); // Entity frameworkde Remove metodu 1 tane kayıt silmek için kullanılır. RemoveRange metodu ise 1 den çok kayıt silmek için kullanılır.
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
