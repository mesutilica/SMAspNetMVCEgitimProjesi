using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCProjesi.Controllers
{
    public class MVC02HtmlHelpersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
