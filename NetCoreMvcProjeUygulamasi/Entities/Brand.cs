namespace NetCoreMvcProjeUygulamasi.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Product>? Products { get; set; } // Marka ile Ürünler arasında 1 e çok ilişki kurduk
    }
}
