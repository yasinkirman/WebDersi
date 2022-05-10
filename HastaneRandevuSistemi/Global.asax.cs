using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace HastaneRandevuSistemi
{
    public class Global : System.Web.HttpApplication
    {
        void Yonlendir(RouteCollection route)
        {
            route.MapPageRoute("Giriş", "GirişYap", "~/Giris.aspx");
            route.MapPageRoute("Kayıt", "UyeOl", "~/UyeOl.aspx");
            route.MapPageRoute("Şifre", "SifremiUnuttum", "~/SifremiUnuttum.aspx");
            route.MapPageRoute("Sekreter Giriş", "SekreterGiris", "~/SekreterGiris.aspx");
            route.MapPageRoute("Hasta Giriş", "HastaGiris", "~/HastaGiris.aspx");
            route.MapPageRoute("Doktor Giriş", "DoktorGiris", "~/DoktorGiris.aspx");
            route.MapPageRoute("Branş EKle", "BransEkle", "~/BransEkle.aspx");
            route.MapPageRoute("Doktor EKle", "DoktorEkle", "~/DoktorEkle.aspx");
            route.MapPageRoute("Sekreter Bilgi", "SekreterBilgi", "~/SekreterBilgi.aspx");
            route.MapPageRoute("Hasta Bilgi", "HastaBilgi", "~/HastaBilgi.aspx");
            route.MapPageRoute("Doktor Bilgi", "DoktorBilgi", "~/DoktorBilgi.aspx");
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            Yonlendir(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}