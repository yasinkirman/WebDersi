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
    
    public partial class Tbl_Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Kullanici()
        {
            this.Tbl_DoktorAsi = new HashSet<Tbl_DoktorAsi>();
            this.Tbl_DoktorCocuk = new HashSet<Tbl_DoktorCocuk>();
            this.Tbl_DoktorYetiskin = new HashSet<Tbl_DoktorYetiskin>();
            this.Tbl_Hastalar = new HashSet<Tbl_Hastalar>();
            this.Tbl_Sekreterler = new HashSet<Tbl_Sekreterler>();
        }
    
        public int Kullaniciid { get; set; }
        public string KullaniciAd { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_DoktorAsi> Tbl_DoktorAsi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_DoktorCocuk> Tbl_DoktorCocuk { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_DoktorYetiskin> Tbl_DoktorYetiskin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Hastalar> Tbl_Hastalar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Sekreterler> Tbl_Sekreterler { get; set; }
    }
}