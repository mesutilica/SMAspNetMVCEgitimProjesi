using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCProjesi.Controllers
{
    public class MVC14SessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SessionOlustur(string kullaniciAdi, string sifre)
        {
            // var kullanici = getkullanici(kullaniciAdi, sifre);
            if (kullaniciAdi == "admin" && sifre == "123")
            {
                HttpContext.Session.SetString("kulAdi", kullaniciAdi);
                HttpContext.Session.SetInt32("sifre", 123);
                HttpContext.Session.SetString("userGuid", Guid.NewGuid().ToString());
                return RedirectToAction("SessionOku");
            }
            return RedirectToAction("Index");
        }
        public IActionResult SessionOku()
        {
            TempData["SessionBilgi"] = HttpContext.Session.GetString("kulAdi");
            TempData["userGuid"] = HttpContext.Session.GetString("userGuid");
            return View();
        }
        public IActionResult SessionSil()
        {
            HttpContext.Session.Remove("kulAdi");
            HttpContext.Session.Remove("userGuid");
            return RedirectToAction("Index");
        }
    }
}
