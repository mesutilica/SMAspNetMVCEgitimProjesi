using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCProjesi.Controllers
{
    public class MVC09ViewToControllerDataController : Controller
    {
        public IActionResult Index(string txtara) // buradaki txtara parametresi querystring den gelen veri
        {
            string test = "deneme";
            ViewBag.ArananKelime = txtara;
            // Burada txtara değerini veritabanına yollayıp eşleşen kayıtları bulup ekrana gönderebiliriz.
            return View();
        }

        [HttpPost] // Aşağıdaki metot post işleminde çalışsın
        public IActionResult Index(string text1, string ddlliste, bool cbOnay, IFormCollection keyValuePairs)
        {
            // 1. Yöntem parametrelerden gelen veriler
            ViewBag.Mesaj = "Textboxdan gelen değer : " + text1;
            ViewBag.Text = "Dropdown dan gelen değer : " + ddlliste;
            ViewBag.cbOnay = "Checbox dan gelen değer : " + cbOnay;

            // 2. Yöntem Request.Form ile gelen veriler

            ViewBag.Mesaj2 = "Textboxdan gelen değer : " + Request.Form["text1"];
            ViewBag.Text2 = "Dropdown dan gelen değer : " + Request.Form["ddlliste"];
            ViewBag.cbOnay2 = "Checbox dan gelen değer : " + Request.Form["cbOnay"][0];

            // 3. Yöntem IFormCollection ile gelen veriler

            ViewBag.Mesaj3 = "Textboxdan gelen değer : " + keyValuePairs["text1"];
            ViewBag.Text3 = "Dropdown dan gelen değer : " + keyValuePairs["ddlliste"];
            ViewBag.cbOnay3 = "Checbox dan gelen değer : " + keyValuePairs["cbOnay"][0];

            return View();
        }


    }
}
