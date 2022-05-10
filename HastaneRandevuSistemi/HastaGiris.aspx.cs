using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HastaneRandevuSistemi
{
    public partial class HastaGiris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var kullanici = new Siniflarim.Hastalar().GetByKullaniciVarMi(TextBox1.Text, TextBox2.Text,TextBox3.Text);
            if (kullanici != null)
            {
                Session["Kullanici"] = kullanici;
                if (kullanici.KullaniciAd == "Hasta")
                {
                    Response.Redirect("HastaBilgi.aspx");
                }
                if (kullanici.KullaniciAd == "Doktor")
                {
                    Response.Redirect("DoktorBilgi.aspx");
                }
                if (kullanici.KullaniciAd == "Sekreter")
                {
                    Response.Redirect("SekreterBilgi.aspx");
                }
            }
        }
    }
}