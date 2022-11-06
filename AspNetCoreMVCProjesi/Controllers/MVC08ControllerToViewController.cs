using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCProjesi.Controllers
{
    public class MVC08ControllerToViewController : Controller
    {
        public IActionResult Index()
        {
            // 3 Temel yöntemle veri gönerilebiliyor

            // 1- ViewBag : Tek kullanımlık ömrü var
            ViewBag.UrunKategorisi = "Bilgisayar";

            // 2- ViewData : Tek kullanımlık ömrü var
            ViewData["UrunAdi"] = "Laptop";

            // 3- TempData : 2 kullanımlık ömrü var
            TempData["UrunFiyati"] = 18000;

            var deneme = "test";
            
            return View();
        }
    }
}
