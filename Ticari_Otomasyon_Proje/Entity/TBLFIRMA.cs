//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ticari_Otomasyon_Proje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLFIRMA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLFIRMA()
        {
            this.TBLFIRMAHAREKET = new HashSet<TBLFIRMAHAREKET>();
        }
    
        public int FIRMAID { get; set; }
        public string AD { get; set; }
        public string SEKTOR { get; set; }
        public string YETKILI { get; set; }
        public string YETKILISTATU { get; set; }
        public string YETKILITC { get; set; }
        public string YETKILITELEFON { get; set; }
        public string FIRMATELEFON { get; set; }
        public string IL { get; set; }
        public string ILCE { get; set; }
        public string VERGIDAIRESI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLFIRMAHAREKET> TBLFIRMAHAREKET { get; set; }
    }
}
