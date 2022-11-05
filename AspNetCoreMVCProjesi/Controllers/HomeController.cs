using AspNetCoreMVCProjesi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCoreMVCProjesi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ContactUs() // yukardaki Privacy action ını kopyala yapıştır yapıp adını ContactUs yaptık
        { // ContactUs.cshtml view ını oluşturmak için ContactUs yazısına sağ tıklayıp add view diyerek açılan ekranda empty veye diğer seçeneği seçip sayfayı oluşturmamız gerekir.
            return View(); // bu action tetiklendiğinde ContactUs.cshtml isimli view ı ekrana getir.
        }

        public ActionResult About() // View oluşturmak için About a sağ tıklayıp açılan menüden add view deyip, gelen pencereden empty i seçerek Add butonuna basarak boş bir view sayfası oluşturabiliriz.
        {
            return View();
        }

        public IActionResult OzelLayoutKullanimi()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}