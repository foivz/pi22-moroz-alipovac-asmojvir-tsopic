using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Zaposlenik
{
    public class RegistracijaView
    {
        public int Id_rezervacije { get; set; }
        public string Gost { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public DateTime DatumDogadaja { get; set; }
        public string Dodao { get; set; }
        public byte Odobreno { get; set; }

    }
}
