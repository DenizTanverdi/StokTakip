//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsAppEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ogrenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ogrenci()
        {
            this.Sehirler = new HashSet<Sehirler>();
        }
    
        public int OgrId { get; set; }
        public string OgrenciAdi { get; set; }
        public string Soyad { get; set; }
        public string OgrenciNo { get; set; }
        public string Cinsiyet { get; set; }
        public System.DateTime DogumTarihi { get; set; }
        public string SehirId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sehirler> Sehirler { get; set; }
        public virtual AlinanDersler AlinanDersler { get; set; }
    }
}