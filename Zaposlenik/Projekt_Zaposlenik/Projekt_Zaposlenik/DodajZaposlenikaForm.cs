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
    public partial class DodajZaposlenikaForm : Form
    {
        public DodajZaposlenikaForm()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "";
            bool greskaDatum = false;
            using (var context = new PI2220_DBEntities())
            {
                string ime = txtIme.Text;
                string prezime = txtPrezime.Text;
                DateTime datumRodenja = datePickRodenje.Value.Date;
                string adresa = txtAdresa.Text;
                int OIB = int.Parse(txtOIB.Text);
                string korisnickoIme = txtKorisnicko.Text;
                string lozinka = txtLozinka.Text;
                Uloga odabranaUloga = cmbUloga.SelectedItem as Uloga;

                if (datumRodenja >= DateTime.Now.Date)
                {
                    greskaDatum = true;
                }

                if (ime == "" || prezime == "" || korisnickoIme == "" || adresa == "" || txtOIB.Text == "" || lozinka == "")
                {
                    poruka = "Ispunite sva polja.";
                }
                else if (greskaDatum == true)
                {
                    poruka = "Pogrešan datum.";
                }
                else
                {
                    Korisnik noviZaposlenik = new Korisnik()
                    {
                        id_korisnik = default,
                        ime = ime,
                        prezime = prezime,
                        datum_rodenja = datumRodenja,
                        adresa = adresa,
                        OIB = OIB,
                        korisnicko_ime = korisnickoIme,
                        lozinka = lozinka,
                        id_uloga = odabranaUloga.id_uloga
                    };
                    context.Korisniks.Add(noviZaposlenik);
                    context.SaveChanges();
                    poruka = "Uspješno dodan zaposlenik.";
                    txtIme.Text = "";
                    txtPrezime.Text = "";
                    datePickRodenje.Value = DateTime.Now;
                    txtAdresa.Text = "";
                    txtOIB.Text = "";
                    txtKorisnicko.Text = "";
                    txtLozinka.Text = "";
                }
            }
            MessageBox.Show(poruka);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DodajZaposlenikaForm_Load(object sender, EventArgs e)
        {
            List<Uloga> uloge = DohvatiUloge();
            cmbUloga.DataSource = uloge;
        }
        private List<Uloga> DohvatiUloge()
        {
            using (var context = new PI2220_DBEntities())
            {
                return context.Ulogas.ToList();
            }
        }

    }
}
