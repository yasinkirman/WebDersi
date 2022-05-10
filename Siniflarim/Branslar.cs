using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
    public class Branslar
    {
        public List<Veritabani.Tbl_Branslar> Listele()
        {
            Veritabani.WebHastaneRandevuSistemiEntities4 ent = new Veritabani.WebHastaneRandevuSistemiEntities4();
            var sonuc = ent.Tbl_Branslar.OrderByDescending(p => p.Bransid).ToList();
            return sonuc;                 
        }
        public string VeriEKle(Veritabani.Tbl_Branslar nesne)
        {
            Veritabani.WebHastaneRandevuSistemiEntities4 ekleme = new Veritabani.WebHastaneRandevuSistemiEntities4();
            Veritabani.Tbl_Branslar yeni = new Veritabani.Tbl_Branslar();
            yeni = nesne;
            ekleme.Tbl_Branslar.Add(yeni);
            int sonuc = ekleme.SaveChanges();
            var verilerigetir = Listele();
            if (sonuc == 1)
                return "1";
            else
                return "0";
        }
        public string VeriGuncelle(string BransAd, Veritabani.Tbl_Branslar nesne)
        {
            Veritabani.WebHastaneRandevuSistemiEntities4 ekleme = new Veritabani.WebHastaneRandevuSistemiEntities4();
            Veritabani.Tbl_Branslar yeni = new Veritabani.Tbl_Branslar();
            var aranan = ekleme.Tbl_Branslar.Where(p => p.BransAd == BransAd).ToList().FirstOrDefault();
            aranan = nesne;
            ekleme.SaveChanges();
            var verilerigetir = Listele();
            return "1";
        }
        public string VerSilme(string BransAd, Veritabani.Tbl_Branslar nesne)
        {
            Veritabani.WebHastaneRandevuSistemiEntities4 ekleme = new Veritabani.WebHastaneRandevuSistemiEntities4();
            Veritabani.Tbl_Branslar yeni = new Veritabani.Tbl_Branslar();
            var aranan = ekleme.Tbl_Branslar.Where(p => p.BransAd == BransAd).FirstOrDefault();
            ekleme.Tbl_Branslar.Remove(aranan);
            ekleme.SaveChanges();
            var verilerigetir = Listele();
            return "1";
        }
    }
}
