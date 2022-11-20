using AspNetCoreMVCProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCProjesi.Controllers
{
    public class MVC15ViewResultsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FarkliViewDondur()
        {
            return View("Index");
        }
        public IActionResult Yonlendir()
        {
            //return Redirect("/Home"); // vereceğimiz url adresine uygulamayı yönlendir
            return Redirect("https://www.google.com.tr/"); // site dışına da yönlendirebiliriz
        }
        public RedirectToActionResult ActionaYonlendir()
        {
            // burada veritabanına bir kayıt eklendikten sonra uygulamayı kayıt listeleme sayfasına yönlendirebiliriz
            return RedirectToAction("Index"); // action çalıştığında uygulamayı başka bir action a yönlendirmemizi sağlar
        }
        public RedirectToRouteResult RouteYonlendir()
        {
            return RedirectToRoute("default", new { controller = "Home", action = "About", id = 18 });
        }
        public PartialViewResult KategorilerGetirPartial()
        {
            return PartialView("_KategorilerPartial");
        }

        public FileStreamResult MetinDosyasiindir()
        {
            string metin = "FileStreamResult ile dosya indirme";
            MemoryStream memory = new MemoryStream();
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(metin);
            memory.Write(bytes, 0, bytes.Length);
            memory.Position = 0;
            FileStreamResult result = new FileStreamResult(memory, "text/plain"); // .txt dosya
            result.FileDownloadName = "metin.txt";
            return result;
        }

        public JsonResult JsonDondur()
        {
            var kullanici = new Kullanici()
            {
                Id = 25,
                Ad = "Murat",
                Soyad = "Yılmaz",
                Email = "test@solid.io",
                KullaniciAdi = "kul"
            };
            return Json(kullanici);
        }

        public ContentResult XmlContentResult()
        {
            var xml = @"
                <kullanicilar>
                    <kullanici>
                        <Id>18</Id>
                        <Ad>Mesut</Ad>
                        <Soyad>Ilıca</Soyad>
                        <Email>mesut@Ilıca</Email>
                    </kullanici>
                    <kullanici>
                        <Id>25</Id>
                        <Ad>Murat</Ad>
                        <Soyad>Ilıca</Soyad>
                        <Email>murat@Ilıca</Email>
                    </kullanici>
                </kullanicilar>
            ";

            return Content(xml, "application/xml");
        }

    }
}
