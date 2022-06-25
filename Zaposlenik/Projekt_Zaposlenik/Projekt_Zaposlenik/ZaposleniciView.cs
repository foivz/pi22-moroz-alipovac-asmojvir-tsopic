using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Zaposlenik
{
    public class ZaposleniciView
    {
        public int IdZaposlenika { get; set; }
        public string Zaposlenik { get; set; } 
        public DateTime? DatumRodenja { get; set; }
        public string Adresa { get; set; }
        public int? OIB { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Uloga { get; set; }
    }
}
