//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt_Zaposlenik
{
    using System;
    using System.Collections.Generic;
    
    public partial class Raspored
    {
        public int id_raspored { get; set; }
        public System.DateTime radni_dan { get; set; }
        public int id_smjena { get; set; }
        public int id_zaposlenik { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual TipSmjene TipSmjene { get; set; }
    }
}
