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
    
    public partial class Narudzba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Narudzba()
        {
            this.stavka_narudzbe = new HashSet<stavka_narudzbe>();
        }
    
        public int id_narudzba { get; set; }
        public int id_stola { get; set; }
        public System.DateTime datum_i_vrijeme { get; set; }
    
        public virtual Stol Stol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stavka_narudzbe> stavka_narudzbe { get; set; }
    }
}
