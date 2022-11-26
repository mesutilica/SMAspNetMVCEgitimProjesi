using Microsoft.AspNetCore.Mvc;

namespace NetCoreMvcProjeUygulamasi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
