namespace AspNetCoreMVCProjesi.Models
{
    public interface IUyeDAL
    {
        void UyeEkle(Uye uye);
        void UyeGuncelle(Uye uye);
        void UyeSil(Uye uye);
        List<Uye> UyeListesi();
    }
}
