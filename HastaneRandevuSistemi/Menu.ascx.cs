using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HastaneRandevuSistemi
{
    public partial class Menu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var yetki = (Veritabani.Tbl_Kullanici)System.Web.HttpContext.Current.Session["Kullanici"];
            var menu = new Siniflarim.Menu().GetByYetki(yetki.KullaniciAd).ToList();
            if (menu!=null)
            {
                string bilgi = "";
                for(int i = 0; i<menu.Count;i++)
                {
                    bilgi += "<li class=\"nav-item\">";
                    bilgi += "<a href = \""+menu[i].MenuAdres+"\" class=\"nav-link\">";
                    bilgi += "<i class=\"nav-icon fas fa-th\"></i>";
                    bilgi += "<p> "+menu[i].MenuAdi+"";
                    bilgi += "<span class=\"right badge badge-danger\">New</span>";
                    bilgi += "</p></a></li>";
                }
                lt_menu.Text += bilgi;
            }
            return;
        }
    }
}