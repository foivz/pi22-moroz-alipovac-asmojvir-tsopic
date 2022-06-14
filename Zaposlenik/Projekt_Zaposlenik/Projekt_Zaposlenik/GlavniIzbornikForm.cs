using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Zaposlenik
{
    public partial class GlavniIzbornikForm : Form
    {
        Korisnik korisnik = new Korisnik();
        public GlavniIzbornikForm(Korisnik prosljedeniKorisnik)
        {
            InitializeComponent();
            korisnik = prosljedeniKorisnik;
        }

        private void buttonNarudzbe_Click(object sender, EventArgs e)
        {
            NarudzbeForm form = new NarudzbeForm(korisnik);
            form.ShowDialog();
            

        }
    }
}
