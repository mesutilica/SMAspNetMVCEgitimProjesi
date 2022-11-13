namespace NetCoreMvcProjeUygulamasi.Models
{
    public class Carousel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; } // ? işareti bu property nin nullable yani boş bırakılabilir olmasını sağlar
        public string? Image { get; set; }
    }
}
