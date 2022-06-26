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
    public partial class AzurirajZaposlenikaForm : Form
    {
        public ZaposleniciView OdabraniKorisnik = new ZaposleniciView();
        public AzurirajZaposlenikaForm(ZaposleniciView odabraniKorisnik)
        {
            InitializeComponent();
            OdabraniKorisnik = odabraniKorisnik;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool greskaDatum = false;
            string upozorenje = "Jeste li sigurni da želite izmjeniti korisnikove podatke?";
            string naslov = "Ažuriranje";
            MessageBoxButtons tipke = MessageBoxButtons.YesNo;
            DialogResult rezultat = MessageBox.Show(upozorenje, naslov, tipke);
            if (rezultat == DialogResult.Yes)
            {
                string poruka = "";
                List<Korisnik> korisnici = new List<Korisnik>();
                korisnici = DohvatiKorisnike();
                Korisnik azuriraniKorisnik = new Korisnik();
                Uloga odabranaUloga = cmbUloga.SelectedItem as Uloga;
                if (azuriraniKorisnik.datum_rodenja >= DateTime.Now.Date)
                {
                    greskaDatum = true;
                }

                if (azuriraniKorisnik.ime == "" || azuriraniKorisnik.prezime == "" || azuriraniKorisnik.korisnicko_ime == "" || azuriraniKorisnik.adresa == "" || txtOIB.Text == "" || azuriraniKorisnik.lozinka == "")
                {
                    poruka = "Ispunite sva polja.";
                }
                else if (greskaDatum == true)
                {
                    poruka = "Pogrešan datum.";
                }
                else
                {
                    using (var context = new PI2220_DBEntities())
                    {
                        foreach (Korisnik korisnik in korisnici)
                        {
                            if (korisnik.id_korisnik == OdabraniKorisnik.IdZaposlenika)
                            {
                                azuriraniKorisnik = korisnik;
                            }
                        }
                        context.Korisniks.Attach(azuriraniKorisnik);
                        azuriraniKorisnik.ime = txtIme.Text;
                        azuriraniKorisnik.prezime = txtPrezime.Text;
                        azuriraniKorisnik.datum_rodenja = datePickRodenje.Value;
                        azuriraniKorisnik.adresa = txtAdresa.Text;
                        azuriraniKorisnik.OIB = int.Parse(txtOIB.Text);
                        azuriraniKorisnik.korisnicko_ime = txtKorisnicko.Text;
                        azuriraniKorisnik.lozinka = txtLozinka.Text;
                        azuriraniKorisnik.id_uloga = odabranaUloga.id_uloga;
                        poruka = "Uspješno ažuriran korisnik.";
                        context.SaveChanges();
                        Close();
                    }
                }
                MessageBox.Show(poruka);
            }
        }

        private void AzurirajZaposlenikaForm_Load(object sender, EventArgs e)
        {
            string[] odvojeno = OdabraniKorisnik.Zaposlenik.Split(' ');
            List<Uloga> uloge = DohvatiUloge();
            cmbUloga.DataSource = uloge;
            cmbUloga.Text = OdabraniKorisnik.Uloga;
            txtIdZaposlenika.Text = OdabraniKorisnik.IdZaposlenika.ToString();
            txtIme.Text = odvojeno[0];
            txtPrezime.Text = odvojeno[1];
            datePickRodenje.Value = OdabraniKorisnik.DatumRodenja.Value;
            txtAdresa.Text = OdabraniKorisnik.Adresa;
            txtOIB.Text = OdabraniKorisnik.OIB.ToString();
            txtKorisnicko.Text = OdabraniKorisnik.KorisnickoIme;
            txtLozinka.Text = OdabraniKorisnik.Lozinka;
        }

        private List<Uloga> DohvatiUloge()
        {
            using (var context = new PI2220_DBEntities())
            {
                return context.Ulogas.ToList();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
        public List<Korisnik> DohvatiKorisnike()
        {
            using (var context = new PI2220_DBEntities())
            {
                return context.Korisniks.ToList();

            }
        }
    }
}
