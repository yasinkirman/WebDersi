using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
    class Kullanici
    {
        public Veritabani.Tbl_Kullanici GetByKullaniciVarMi(string KullaniciAd,string Sifre, string Yetki)
        {
            Veritabani.WebHastaneRandevuSistemiEntities4 ent = new Veritabani.WebHastaneRandevuSistemiEntities4();
            var sonuc =ent.Tbl_Kullanici.Where(p=>p.KullaniciAd==KullaniciAd&&K)
        }
    }
}
