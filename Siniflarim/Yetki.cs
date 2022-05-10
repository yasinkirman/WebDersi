using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;

namespace Siniflarim
{
    class Yetki
    {
        public enum Yetki
        {
            Hasta=1,
            Doktor=2,
            Sekreter=3
        }
        public class YektiKontrol: System.Web.UI.Page
        {
            protected override void OnLoad(EventArgs e)
            {
                var yetki = (Veritabani.Tbl_Kullanici)System.Web.HttpContext.Current.Session["Kullanici"];
                if (yetki.KullaniciAd != "Hasta")
                {
                    Response.Redirect("/Giris.aspx");
                }
                base.OnLoad(e);
            }
        }
    }
}
