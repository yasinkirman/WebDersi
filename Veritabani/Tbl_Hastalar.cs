//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Veritabani
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Hastalar
    {
        public int Hastaid { get; set; }
        public string HastaAd { get; set; }
        public string HastaSoyad { get; set; }
        public string HastaTc { get; set; }
        public string HastaTelefon { get; set; }
        public string HastaSifre { get; set; }
        public Nullable<int> CinsiyetidFk { get; set; }
        public Nullable<int> KullaniciidFk { get; set; }
    
        public virtual Tbl_Cinsiyet Tbl_Cinsiyet { get; set; }
        public virtual Tbl_Kullanici Tbl_Kullanici { get; set; }
        public string KullaniciAd { get; set; }
    }
}