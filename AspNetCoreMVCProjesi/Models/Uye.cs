using System.ComponentModel.DataAnnotations; // Validation için gerekli kütüphane

namespace AspNetCoreMVCProjesi.Models
{
    public class Uye
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanı boş geçilemez!"), StringLength(50)]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Soyad alanı boş geçilemez!"), StringLength(50)]
        public string Soyad { get; set; }
        [Required(ErrorMessage = "Email alanı boş geçilemez!"), StringLength(50)]
        [EmailAddress(ErrorMessage = "Geçersiz Mail!")]
        public string Email { get; set; }
        [Phone(ErrorMessage = "Geçersiz Telefon!")]
        public string? Telefon { get; set; } // Telefon alanının zorunlu olmaması için ? işareti koyuyoruz
        [Required(ErrorMessage = "Tc No alanı boş geçilemez!"), StringLength(11)]
        [Display(Name = "TC Kimlik Numarası")] // Ekranda TcKimlikNo yerine TC Kimlik Numarası yazması için
        [MinLength(11, ErrorMessage = "{0} 11 Karakter Olmalıdır")]
        [MaxLength(11, ErrorMessage = "{0} 11 Karakter Olmalıdır")]
        public string TcKimlikNo { get; set; }
        [Display(Name = "Doğum Tarihi")]
        public DateTime DogumTarihi { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez!"), StringLength(50)]
        public string KullaniciAdi { get; set; }
        [Display(Name = "Şifre"), DataType(DataType.Password)] // Şifre inputunun türü password olsun
        [Required(ErrorMessage = "{0} alanı boş geçilemez!"), StringLength(50)]
        public string Sifre { get; set; }
        [Display(Name = "Şifrenizi Tekrar Giriniz"), DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} alanı boş geçilemez!"), StringLength(50)]
        [Compare("Sifre")] // SifreTekrar alanını Sifre alanıyla karşılaştır
        public string SifreTekrar { get; set; }
    }
}
