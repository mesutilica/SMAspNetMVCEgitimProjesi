using Microsoft.EntityFrameworkCore;
using NetCoreMvcProjeUygulamasi.Entities;
using NetCoreMvcProjeUygulamasi.Models;

namespace NetCoreMvcProjeUygulamasi.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Carousel> Carousels { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
