//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt_Gost
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vrsta_artikla
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vrsta_artikla()
        {
            this.Artikls = new HashSet<Artikl>();
        }
    
        public int id_vrste_artikla { get; set; }
        public string naziv_vrste_artikla { get; set; }
        public int stopa_poreza { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artikl> Artikls { get; set; }
    }
}