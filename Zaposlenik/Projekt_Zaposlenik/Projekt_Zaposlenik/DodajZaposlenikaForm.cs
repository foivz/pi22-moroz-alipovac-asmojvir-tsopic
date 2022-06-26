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
                int id_uloga = int.Parse(txtUlogaId.Text);

                if (datumRodenja >= DateTime.Now.Date)
                {
                   greskaDatum = true;
                }

                if (ime == "" || prezime == "" || korisnickoIme == "" || adresa == "" || txtOIB.Text == "" || lozinka == "" || txtUlogaId.Text == "")
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
                        id_uloga = id_uloga
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
                    txtUlogaId.Text = "";
                }
            }
            MessageBox.Show(poruka);
        }

    }
}
