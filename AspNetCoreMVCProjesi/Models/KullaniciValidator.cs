using FluentValidation; // FluentValidation kütüphanesi ile class validasyonu yapmak için 

namespace AspNetCoreMVCProjesi.Models
{
    public class KullaniciValidator : AbstractValidator<Kullanici> //FluentValidation dan gelen AbstractValidator sınıfına kontrol ettireceğimiz classı bu şekilde belirtiyoruz
    {
        public KullaniciValidator()
        {
            RuleFor(x => x.Ad).NotNull();
            RuleFor(x => x.Soyad).NotEmpty().WithMessage("Soyadı boş geçilemez!");
            RuleFor(x => x.Email).EmailAddress().NotNull().WithMessage("Email boş geçilemez!");
            RuleFor(x => x.KullaniciAdi).NotEmpty();
            RuleFor(x => x.Sifre).NotNull().WithMessage("Şifre boş geçilemez!").Length(3, 20);
        }
    }
}
