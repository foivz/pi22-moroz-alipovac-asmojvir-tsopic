using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Zaposlenik
{
    public class ArtiklView
    {
        public int ArtiklId { get; set; }
        public string naziv { get; set; }
        public double kolicinaL { get; set; }
        public int skladiste { get; set; }
        public double cijena { get; set; }
        public string vrsta { get; set; }
    }
}
