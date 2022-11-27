using System.ComponentModel.DataAnnotations;

namespace NetCoreMvcProjeUygulamasi.Entities
{
    public class Carousel
    {
        public int Id { get; set; }

        [Display(Name = "Başlık"), StringLength(150)]
        public string? Title { get; set; }

        [Display(Name = "Açıklama"), StringLength(500)]
        public string? Description { get; set; } // ? işareti bu property nin nullable yani boş bırakılabilir olmasını sağlar

        [Display(Name = "Resim"), StringLength(150)]
        public string? Image { get; set; }
    }
}
