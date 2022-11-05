using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCProjesi.Controllers
{
    public class MVC01RazorSyntaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
