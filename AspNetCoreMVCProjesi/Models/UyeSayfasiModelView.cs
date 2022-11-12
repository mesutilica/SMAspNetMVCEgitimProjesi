namespace AspNetCoreMVCProjesi.Models
{
    public class UyeSayfasiModelView
    {
        // Eğer sayfada 1 den fazla model classı kullanmak istersek bu classları başka bir ModelView classı içerisinde tanımlayıp kullanabiliriz.
        //public int MyProperty { get; set; }
        public Kullanici KullaniciBilgisi { get; set; } // Burada yeni bir class oluşturmuyoruz var olan kullanici classını property olarak UyeSayfasiModelView classında kullanıyoruz
        public Adres AdresBilgisi { get; set; }
        // burada artık istediğimiz kadar class tanımlayarak devam edebiliriz
    }
}
