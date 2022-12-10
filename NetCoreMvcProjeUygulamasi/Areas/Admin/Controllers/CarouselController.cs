using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreMvcProjeUygulamasi.Data;
using NetCoreMvcProjeUygulamasi.Entities;

namespace NetCoreMvcProjeUygulamasi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CarouselController : Controller
    {
        // SOLID deki D harfi dependency inversion
        // Dependency Injection işlemi ile context oluşturma
        private readonly DatabaseContext _context; // Burada boş bir DatabaseContext nesnesi oluşturduk
        // _context e sağ klik açılan menüden Quick actions ile başlayan menüye tıkladık
        // 1 menü daha açılacak oradan da generate constructor menüsüne tıklıyoruz ve aşağıdaki kurucu metot oluşuyor
        public CarouselController(DatabaseContext context) // Burada CarouselController sınıfının kurucu metodu çalıştığı anda parantez içinde yazdığımız context nesnesi .net core tarafından arka planda otomatik olarak new lenerek yeni bir nesne oluşturulur
        {
            _context = context; // eşitliğin sağındaki context nesnesi sistem tarafından oluşturulan içi dolu nesne, soldaki ise yukarıda tanımladığımız içi boş nesne. Dolu olan soldaki boşa eşitlenince aşağıdaki tüm actionlarda kullanılabilir hale geliyor.
        }

        // GET: CarouselController
        public async Task<ActionResult> IndexAsync()
        {
            var model = await _context.Carousels.ToListAsync();
            return View(model);
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
        public ActionResult Create(Carousel carousel, IFormFile? Image)
        {
            try
            {
                if (Image is not null)
                {
                    string klasor = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + Image.FileName; // yükleme yapacağımız klasörü belirttik
                    using var stream = new FileStream(klasor, FileMode.Create); // yükleme için gerekli veri akışı oluşturduk
                    Image.CopyTo(stream); // veri akışını kullanarak yükleme yaptık
                    carousel.Image = Image.FileName;
                }
                _context.Carousels.Add(carousel);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarouselController/Edit/5
        public async Task<ActionResult> EditAsync(int id)
        {
            var model = await _context.Carousels.FindAsync(id);
            return View(model);
        }

        // POST: CarouselController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Carousel carousel, IFormFile? Image)
        {
            try
            {
                if (Image is not null)
                {
                    string klasor = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + Image.FileName;
                    using var stream = new FileStream(klasor, FileMode.Create);
                    Image.CopyTo(stream);
                    carousel.Image = Image.FileName;
                }
                _context.Carousels.Update(carousel);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarouselController/Delete/5
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var model = await _context.Carousels.FindAsync(id);
            return View(model);
        }

        // POST: CarouselController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Carousel carousel)
        {
            try
            {
                _context.Carousels.Remove(carousel);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
