using System.ComponentModel.DataAnnotations;

namespace NetCoreMvcProjeUygulamasi.Models
{
    public class Contact
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
        [Required(ErrorMessage = "{0} alanı boş geçilemez!"), StringLength(500), Display(Name = "Mesaj")]
        public string Message { get; set; }
    }
}
