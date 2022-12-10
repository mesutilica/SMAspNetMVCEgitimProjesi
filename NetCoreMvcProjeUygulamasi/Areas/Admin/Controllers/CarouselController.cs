using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreMvcProjeUygulamasi.Data;

namespace NetCoreMvcProjeUygulamasi.Areas.Admin.Controllers
{
    public class CarouselController : Controller
    {
        // Dependency Injection işlemi ile context oluşturma
        private readonly DatabaseContext _context; // Burada boş bir DatabaseContext nesnesi oluşturduk
        // _context e sağ klik açılan menüden Quick actions ile başlayan menüye tıkladık
        // 1 menü daha açılacak oradan da generate constructor menüsüne tıklıyoruz ve aşağıdaki kurucu metot oluşuyor
        public CarouselController(DatabaseContext context) // Burada CarouselController sınıfının kurucu metodu çalıştığı anda parantez içinde yazdığımız context nesnesi .net core tarafından arka planda otomatik olarak new lenerek yeni bir nesne oluşturulur
        {
            _context = context; // eşitliğin sağındaki context nesnesi sistem tarafından oluşturulan içi dolu nesne, soldaki ise yukarıda tanımladığımız içi boş nesne. Dolu olan soldaki boşa eşitlenince aşağıdaki tüm actionlarda kullanılabilir hale geliyor.
        }

        // GET: CarouselController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CarouselController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CarouselController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarouselController/Create
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

        // GET: CarouselController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarouselController/Edit/5
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

        // GET: CarouselController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarouselController/Delete/5
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
