using AspNetCoreMVCProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCProjesi.Controllers
{
    public class MVC11ModelValidationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UyeListesi()
        {
            var uyeListesi = new List<Uye>()
            {
                new Uye() { Id = 18, Ad= "Alp", Soyad = "Arslan", Email = "alp@arslan.net"},
                new Uye() { Id = 25, Ad= "Murat", Soyad = "Yılmaz", Email = "murat@yilmaz.net"},
                new Uye() { Id = 34, Ad= "Pusat", Soyad = "Kılıç", Email = "pusat@arslan.net"}
            };
            uyeListesi.Add(new Uye() { Id = 1453, Ad = "Fatih", Soyad = "Sultan", Email = "fatih@sultan.net" });

            return View(uyeListesi); // sayfaya model olarak uyelistesini yolladık
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Uye uye)
        {
            if (ModelState.IsValid) // Eğer model nesnesi (uye) validasyon kuralları geçerliyse
            {
                // Kurallara uyulmuşsa uye nesnesini veritabanına ekle
            }
            if (!ModelState.IsValid) // ! model durmu geçersizse
            {
                // kullanıcıya hata mesajı göster
                ModelState.AddModelError("", "Lütfen tüm zorunlu alanları doldurunuz!"); // Bu metotla ekrana kendi hata mesajlarımızı da gönderebiliriz.
            }
            return View(uye);
        }
        public IActionResult Edit(int id) // Edit kayıt düzenleme sayfasıdır
        {
            // Edit get metodunda veritabanına bağlanıp güncellenecek kaydı ekrana yollarız
            var model = new Uye() { Id = 1453, Ad = "Fatih", Soyad = "Sultan", Email = "fatih@sultan.net" };

            return View(model); // view a model olarak db(database=veritabanı) den gelen kayıt yollanır
        }
        [HttpPost]
        public IActionResult Edit(Uye uye, int id)
        {
            if (ModelState.IsValid) // Eğer model nesnesi (uye) validasyon kuralları geçerliyse
            {
                // Kurallara uyulmuşsa uye nesnesini veritabanında güncelle
            }
            return View();
        }
        public IActionResult Delete(int id) // Edit kayıt düzenleme sayfasıdır
        {
            // Edit get metodunda veritabanına bağlanıp güncellenecek kaydı ekrana yollarız
            var model = new Uye() { Id = 1453, Ad = "Fatih", Soyad = "Sultan", Email = "fatih@sultan.net" };

            return View(model); // view a model olarak db(database=veritabanı) den gelen kayıt yollanır
        }
        [HttpPost]
        public IActionResult Delete(Uye uye, int id)
        {
            if (ModelState.IsValid) // Eğer model nesnesi (uye) validasyon kuralları geçerliyse
            {
                // Kurallara uyulmuşsa uye nesnesini veritabanından sil
            }
            return View();
        }
    }
}
