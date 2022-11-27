using System.ComponentModel.DataAnnotations;

namespace NetCoreMvcProjeUygulamasi.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} alanı boş geçilemez!"), StringLength(50), Display(Name = "Ad")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} alanı boş geçilemez!"), StringLength(50), Display(Name = "Soyad")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "{0} alanı boş geçilemez!"), StringLength(50), EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Telefon"), StringLength(20)]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "{0} alanı boş geçilemez!"), StringLength(50), Display(Name = "Şifre")]
        public string Password { get; set; }
        [Display(Name = "Durum")]
        public bool IsActive { get; set; }
        [Display(Name = "Admin")]
        public bool IsAdmin { get; set; }
    }
}
