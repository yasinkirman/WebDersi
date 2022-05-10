using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflarim
{
    public class Menu
    {
        public List<Veritabani.Tbl_Menu> GetByYetki(string YetkiAd)
        {
            Veritabani.WebHastaneRandevuSistemiEntities4 ent = new Veritabani.WebHastaneRandevuSistemiEntities4();
            var sonuc = ent.Tbl_Menu.Where(p => p.MenuYetki == YetkiAd && p.MenuDurum == "1").ToList();
            return sonuc;
        }
    }
}
