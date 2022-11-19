using AspNetCoreMVCProjesi.Models;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AspNetCoreMVCProjesi.Controllers
{
    public class MVC12FluentValidationController : Controller
    {
        private readonly IValidator<Kullanici> _validator; // FluentValidation ı kullanarak doğrulama yapabilmek için

        public MVC12FluentValidationController(IValidator<Kullanici> validator) // bu işleme dependency injection denir
        {
            _validator = validator; // burada yukarıda tanımladığımız _validator nesnesinin içerisi doldurulur.
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> IndexAsync(Kullanici kullanici)
        {
            FluentValidation.Results.ValidationResult result = await _validator.ValidateAsync(kullanici); // kullanici nesnesi için FluentValidation ile doğrulama yap

            if (!result.IsValid) // doğrulama başarısızsa
            {
                foreach (var error in result.Errors) // oluşan hatalar içinde dön
                {
                    ModelState.Remove(error.PropertyName); // .net core hata mesajını kaldır
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage); // ModelState e FluentValidation hatalarını ekle
                    ModelState.AddModelError("", error.ErrorMessage); // hataları üst kısımda göstermek için
                }
                return View("Index", kullanici);
            }
            // Eğer validasyon başarılıysa burada ilgili işlem yaptırılır.
            TempData["mesaj"] = "Kayıt Başarılı!";
            return RedirectToAction("Index"); // işlem başarılıysa index e yönlendir
        }
    }
}
