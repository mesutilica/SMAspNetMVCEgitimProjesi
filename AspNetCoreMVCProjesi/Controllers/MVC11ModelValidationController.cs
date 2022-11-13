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
            return View(uye);
        }
    }
}
