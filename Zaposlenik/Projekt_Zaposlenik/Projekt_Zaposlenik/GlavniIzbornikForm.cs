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

        private void buttonPopisPica_Click(object sender, EventArgs e)
        {
            PopisPicaForm form = new PopisPicaForm();
            form.ShowDialog();
        }

        private void buttonStatistika_Click(object sender, EventArgs e)
        {
            StatistikaForm form = new StatistikaForm();
            form.ShowDialog();
        }

        private void buttonRezervacije_Click(object sender, EventArgs e)
        {
            RezervacijaForm form = new RezervacijaForm();
            form.ShowDialog();
        }

        private void buttonRaspored_Click(object sender, EventArgs e)
        {
            RasporedForma form = new RasporedForma();
            form.ShowDialog();
        }

        private void buttonProfili_Click(object sender, EventArgs e)
        {
            ZaposleniciForm form = new ZaposleniciForm(korisnik);
            form.ShowDialog();
        }

        private void buttonSkladiste_Click(object sender, EventArgs e)
        {
            SkladisteForm form = new SkladisteForm();
            form.ShowDialog();
        }

        private void GlavniIzbornikForm_Load(object sender, EventArgs e)
        {
            if (korisnik.id_uloga==1)
            {
                buttonStatistika.Enabled = false;
                buttonProfili.Enabled = false;
            }
            else if (korisnik.id_uloga == 2)
            {
                buttonProfili.Enabled = false;
            }
        }
    }
}
