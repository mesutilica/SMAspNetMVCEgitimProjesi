using AspNetCoreMVCProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCProjesi.Controllers
{
    public class MVC10ModelBindingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult KullaniciSayfasi()
        {
            Kullanici kullanici = new Kullanici()
            {
                Ad = "Murat",
                Soyad = "Yılmaz",
                Email = "ali@veli.co",
                KullaniciAdi = "murat",
                Sifre = "123"
            };

            return View(kullanici); // View sayfasına model nesnemizi parantez içerisinde parametre olarak gönderiyoruz.
        }
        [HttpPost]
        public IActionResult KullaniciSayfasi(Kullanici kullanici) // Ekrandan modelle gönderilen kullanıcı nesnesini bu şekilde action metoduna parametre ekleyerek yakalayabiliyoruz.
        {
            // Burada parametreden gelen kullanici nesnesini veritabanına kaydedebiliriz.
            return View(kullanici); // Sayfadan gelen kullanıcı modelini bu şekilde tekrar post işleminden sonra sayfaya geri gönderebiliyoruz.
        }
        public IActionResult AdresSayfasi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdresSayfasi(Adres adres)
        {
            // gelen veriyi kaydedebiliriz
            return View(adres);
        }
        public IActionResult UyeSayfasi()
        {
            Kullanici kullanici = new Kullanici()
            {
                Ad = "Murat",
                Soyad = "Yılmaz",
                Email = "ali@veli.co",
                KullaniciAdi = "murat",
                Sifre = "123"
            };
            var model = new UyeSayfasiModelView()
            {
                KullaniciBilgisi = kullanici,
                AdresBilgisi = new Adres
                {
                    Sehir = "İstanbul",
                    Ilce = "Ataşehir",
                    AcikAdres = "Deneme Adres"
                }
            };
            return View(model);
        }
    }
}
