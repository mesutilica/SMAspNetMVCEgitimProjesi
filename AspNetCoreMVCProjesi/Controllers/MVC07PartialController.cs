using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCProjesi.Controllers
{
    public class MVC07PartialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
