using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
    public class Hastalar
    {
        public List<Veritabani.Tbl_Hastalar> Listele()
        {
            Veritabani.WebHastaneRandevuSistemiEntities4 ent = new Veritabani.WebHastaneRandevuSistemiEntities4();
            var sonuc = ent.Tbl_Hastalar.OrderByDescending(p => p.Hastaid).ToList();
            return sonuc;
        }
        public Veritabani.Tbl_Hastalar GetByKullaniciVarMi(string HastaTC, string HastaSifre, string Yetki)
        {
            Veritabani.WebHastaneRandevuSistemiEntities4 ent = new Veritabani.WebHastaneRandevuSistemiEntities4();
            var sonuc = ent.Tbl_Hastalar.Where(p => p.HastaTc == HastaTC && p.HastaSifre == HastaSifre && p.Tbl_Kullanici.KullaniciAd==Yetki);
            if (sonuc != null)
            {
                return sonuc.FirstOrDefault();
            }
            else
                return null;
        }
        public string VeriEKle(Veritabani.Tbl_Hastalar nesne)
        {
            Veritabani.WebHastaneRandevuSistemiEntities4 ekleme = new Veritabani.WebHastaneRandevuSistemiEntities4();
            Veritabani.Tbl_Hastalar yeni = new Veritabani.Tbl_Hastalar();
            yeni = nesne;
            ekleme.Tbl_Hastalar.Add(yeni);
            int sonuc = ekleme.SaveChanges();
            var verilerigetir = Listele();
            if (sonuc == 1)
                return "1";
            else
                return "0";
        }
        public string VeriGuncelle(string HastaAd, Veritabani.Tbl_Hastalar nesne)
        {
            Veritabani.WebHastaneRandevuSistemiEntities4 ekleme = new Veritabani.WebHastaneRandevuSistemiEntities4();
            Veritabani.Tbl_Hastalar yeni = new Veritabani.Tbl_Hastalar();
            var aranan = ekleme.Tbl_Hastalar.Where(p => p.HastaAd == HastaAd).ToList().FirstOrDefault();
            aranan = nesne;
            ekleme.SaveChanges();
            var verilerigetir = Listele();
            return "1";
        }
        public string VerSilme(string HastaAd, Veritabani.Tbl_Hastalar nesne)
        {
            Veritabani.WebHastaneRandevuSistemiEntities4 ekleme = new Veritabani.WebHastaneRandevuSistemiEntities4();
            Veritabani.Tbl_Hastalar yeni = new Veritabani.Tbl_Hastalar();
            var aranan = ekleme.Tbl_Hastalar.Where(p => p.HastaAd == HastaAd).FirstOrDefault();
            ekleme.Tbl_Hastalar.Remove(aranan);
            ekleme.SaveChanges();
            var verilerigetir = Listele();
            return "1";
        }

    }
}
