namespace NetCoreMvcProjeUygulamasi.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.Now; // eğer bu alan boş geçilirse eklenme zamanını sistemden otomatik al
        public bool IsActive { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}
