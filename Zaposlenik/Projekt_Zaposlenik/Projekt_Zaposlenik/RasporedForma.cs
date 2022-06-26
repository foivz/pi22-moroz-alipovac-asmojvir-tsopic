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
    public partial class RasporedForma : Form
    {
        public Korisnik Prijavljeni;
        public RasporedForma(Korisnik prijavljeni)
        {
            InitializeComponent();
            Prijavljeni = prijavljeni;
        }

        private void RasporedForma_Load(object sender, EventArgs e)
        {
            Osvjezi();
            if(Prijavljeni.id_uloga == 1)
            {
                button3.Enabled = false;
                buttonAzuriraj.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
                buttonAzuriraj.Enabled = true;
            }
        }

        private void Osvjezi()
        {
            using (var context = new PI2220_DBEntities())
            {
                var upit = from r in context.Rasporeds
                           select new RasporedIspis
                           {
                               ID = r.id_raspored,
                               Dan = r.radni_dan,
                               Smjena = r.TipSmjene.tip_smjene,
                               Ime = r.Korisnik.ime,
                               Prezime = r.Korisnik.prezime,
                               Pocetak = r.TipSmjene.vrijeme_pocetka,
                               Kraj = r.TipSmjene.vrijeme_kraja
                           };

                dataGridViewRaspored.DataSource = upit.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajRasporedForm form = new DodajRasporedForm();
            form.ShowDialog();
            Osvjezi();
        }

        private void buttonAzuriraj_Click(object sender, EventArgs e)
        {
            RasporedIspis raspored = dataGridViewRaspored.CurrentRow.DataBoundItem as RasporedIspis;
            AzurirajRasporedForm form = new AzurirajRasporedForm(raspored);
            form.ShowDialog();
            Osvjezi();
        }

        private void buttonFiltriraj_Click(object sender, EventArgs e)
        {
            using (var context = new PI2220_DBEntities()) {
                DateTime datum = dateTimePicker1.Value;

                var upit = from r in context.Rasporeds
                           where r.radni_dan == datum.Date
                           select new RasporedIspis
                           {
                               ID = r.id_raspored,
                               Dan = r.radni_dan,
                               Smjena = r.TipSmjene.tip_smjene,
                               Ime = r.Korisnik.ime,
                               Prezime = r.Korisnik.prezime,
                               Pocetak = r.TipSmjene.vrijeme_pocetka,
                               Kraj = r.TipSmjene.vrijeme_kraja
                           };

                dataGridViewRaspored.DataSource = upit.ToList();
            }

        }

        private void buttonOsvjezi_Click(object sender, EventArgs e)
        {
            Osvjezi();
        }
    }
}
