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
    
    public partial class Seferler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seferler()
        {
            this.Biletlers = new HashSet<Biletler>();
        }
    
        public int SeferID { get; set; }
        public Nullable<int> KalkisSehirID { get; set; }
        public Nullable<int> VarisSehirID { get; set; }
        public Nullable<int> OtobusID { get; set; }
        public Nullable<int> SoforID { get; set; }
        public Nullable<int> MuavinID { get; set; }
        public Nullable<System.DateTime> KalkisZamani { get; set; }
        public string TahminiSure { get; set; }
        public string BiletTutari { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Biletler> Biletlers { get; set; }
        public virtual Calisanlar Calisanlar { get; set; }
        public virtual Calisanlar Calisanlar1 { get; set; }
        public virtual Otobusler Otobusler { get; set; }
        public virtual Sehirler Sehirler { get; set; }
        public virtual Sehirler Sehirler1 { get; set; }
    }
}
