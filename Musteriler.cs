//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtobusFirması
{
    using System;
    using System.Collections.Generic;
    
    public partial class Musteriler
    {
        public int MusteriID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public Nullable<decimal> Telefon { get; set; }
        public string Cinsiyet { get; set; }
        public Nullable<int> SehirID { get; set; }
    
        public virtual Biletler Biletler { get; set; }
        public virtual Sehirler Sehirler { get; set; }
    }
}
