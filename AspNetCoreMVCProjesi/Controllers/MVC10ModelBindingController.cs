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
    }
}
