using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCProjesi.Controllers
{
    public class MVC16FileUploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] // HttpPost attribute ü aşağıdaki metodun sadece Post yöntemiyle çalışacağını belirtir
        public IActionResult Index(IFormFile? Image) // IFormFile? daki ? işareti ekrandan bir dosya gönderilebileceğini belirtir
        {
            if (Image is not null)
            {
                string klasor = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + Image.FileName; // yükleme yapacağımız klasörü belirttik
                using var stream = new FileStream(klasor, FileMode.Create); // yükleme için gerekli veri akışı oluşturduk
                Image.CopyTo(stream); // veri akışını kullanarak yükleme yaptık
                TempData["Resim"] = Image.FileName;
            }
            return View();
        }
    }
}
