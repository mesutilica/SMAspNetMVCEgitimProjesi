using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCProjesi.Areas.Admin.Controllers
{
    [Area("Admin")] // bu controller ın admin areası içerisinde çalışması için bu kod gerekli!
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
