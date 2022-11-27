using Microsoft.EntityFrameworkCore;
using NetCoreMvcProjeUygulamasi.Entities;
using NetCoreMvcProjeUygulamasi.Models;

namespace NetCoreMvcProjeUygulamasi.Data
{
    public class DatabaseContext : DbContext
    {
        // Entity framework de CodeFirst tekniğini kullandık, bu teknikde önce projede entity class ları oluşturulur sonra veritabanı ve tabloları oluşturulur
        // Diğer yöntem ise DatabaseFirst tekniğidir, bu yöntemde ise önce veritabanı ve tablolar sql server da oluşturulur, sonra bu tablolara bakarak class lar yazılır
        // Her 2 yaklaşımda da hem tabloların hem de class ların yapılarının aynı olması gerekir
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Carousel> Carousels { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Burası veritabanı yapılandırma ayarlarını yapabileceğimiz metot
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; database=NetCoreMvcProjeUygulamasi; integrated security=true;");
            //optionsBuilder.UseInMemoryDatabase("NetCoreMvcProjeUygulamasi");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Burası veritabanımız oluştuktan sonra model classları ile ilgili işlemlerin yapılabileceği metot
            base.OnModelCreating(modelBuilder);
        }
    }
}

// Not : Entitilerimizi oluşturduktan sonra Migration oluşturmamız gerekir
// Migration oluşturmak için : PackageManagerConsole komut ekranını açıyoruz(Eğer bu ekran kapalıysa üst menüden Tools > NugetPackageManager > PackageManagerConsole menüsüne tıklayarak açabiliriz) add-migration EntitilerGuncellendi(EntitilerGuncellendi veya InitialCreate oluşacak Migration ın ismidir, her migration da bir isim vermemiz gerekir)
// Migration oluştuktan sonra değişiklikleri veritabanına yansıtmak için PMC komut ekranında update-database yazıp enter a basmalıyız