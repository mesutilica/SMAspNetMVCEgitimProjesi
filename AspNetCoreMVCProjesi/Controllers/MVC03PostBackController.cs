using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCProjesi.Controllers
{
    public class MVC03PostBackController : Controller
    {
        [HttpGet] // soldaki attrübütü vermesek de varsayılan değer budur.
        public IActionResult Index() // Action'ın üstünde herhangi bir metot türü belirtilmezse varsayılan olarak bu metot GET metodudur
        {
            return View();
        }
        [HttpPost] // Soldaki attribute ü eklediğimzde aşağıdaki action sadece sayfada post işlemi gerçekleştiğinde çalışır.
        public IActionResult Index(string txtad) // Bu actiton'ın türü HttpPost dur. Bir metodun aynısını yaparsak mvc buna izin vermez. Bunu çözmek için metot imzasında herhangi bir değişken parametresi vermemiz yeterlidir.
        {
            return View();
        }
    }
}
