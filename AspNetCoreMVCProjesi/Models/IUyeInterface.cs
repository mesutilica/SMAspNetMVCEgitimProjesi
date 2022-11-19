namespace AspNetCoreMVCProjesi.Models
{
    public interface IUyeInterface // interface leri class ların arayüzlerini oluşturmak için kullanırız
    {
        string Name { get; } // property tanımlama
        public int Id { get; set; }
        void UyeEkle(); // metot imzası
    }
}
