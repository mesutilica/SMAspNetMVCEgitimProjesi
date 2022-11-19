namespace AspNetCoreMVCProjesi.Models
{
    public class UyeDAL : IUyeDAL
    {
        public void UyeEkle(Uye uye)
        {
            // burada uye parametresi ile gelen nesne veritabanına kaydedilir
        }

        public void UyeGuncelle(Uye uye)
        {
            // burada güncelleme kodları bulunur
        }

        public List<Uye> UyeListesi()
        {
            throw new NotImplementedException();
        }

        public void UyeSil(Uye uye)
        {
            // burada uye silme kodu olur
        }
    }
}
