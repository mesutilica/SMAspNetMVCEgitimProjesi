using System.ComponentModel.DataAnnotations;

namespace NetCoreMvcProjeUygulamasi.Entities
{
    public class Brand
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez!"), StringLength(50), Display(Name = "Marka Adı")]
        public string Name { get; set; }

        [Display(Name = "Marka Açıklaması")]
        public string? Description { get; set; }
        
        [StringLength(150)]
        public string? Logo { get; set; } = ""; // property e varsayılan değer atama

        [Display(Name = "Durum")]
        public bool IsActive { get; set; }

        public virtual ICollection<Product>? Products { get; set; } // Marka ile Ürünler arasında 1 e çok ilişki kurduk
    }
}
