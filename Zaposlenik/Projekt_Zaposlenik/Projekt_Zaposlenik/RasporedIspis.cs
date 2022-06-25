using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Zaposlenik
{
    public class RasporedIspis
    {
        public int ID { get; set; }
        public DateTime Dan { get; set; }
        public string Smjena { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public TimeSpan Pocetak {get; set; }
        public TimeSpan Kraj { get; set; }
    }
}
