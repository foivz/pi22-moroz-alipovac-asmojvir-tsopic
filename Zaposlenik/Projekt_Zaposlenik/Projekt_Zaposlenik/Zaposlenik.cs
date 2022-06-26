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
    public partial class ZaposleniciForm : Form
    {
        public ZaposleniciForm()
        {
            InitializeComponent();
        }

        private void ZaposleniciForm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
        private void Osvjezi()
        {
            DohvatiKorisnike();
        }

        private void DohvatiKorisnike()
        {
            using (var context = new PI2220_DBEntities())
            {
                var query = from k in context.Korisniks
                            select new ZaposleniciView
                            {
                                IdZaposlenika = k.id_korisnik,
                                Zaposlenik = k.ime +" "+k.prezime,
                                DatumRodenja = k.datum_rodenja,
                                Adresa = k.adresa,
                                OIB = k.OIB,
                                KorisnickoIme = k.korisnicko_ime,
                                Lozinka = k.lozinka,
                                Uloga = k.Uloga.naziv_uloge
                            };
                dgvZaposlenici.DataSource = query.ToList();
                dgvZaposlenici.Columns[0].HeaderText = "Id zaposlenika";
                dgvZaposlenici.Columns[1].HeaderText = "Zaposlenik";
                dgvZaposlenici.Columns[2].HeaderText = "Datum rođenja";
                dgvZaposlenici.Columns[3].HeaderText = "Adresa";
                dgvZaposlenici.Columns[4].HeaderText = "OIB";
                dgvZaposlenici.Columns[5].HeaderText = "Korisničko ime";
                dgvZaposlenici.Columns[6].HeaderText = "Lozinka";
                dgvZaposlenici.Columns[7].HeaderText = "Uloga";
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajZaposlenikaForm form = new DodajZaposlenikaForm();
            form.ShowDialog();
            Osvjezi();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            ZaposleniciView odabraniKorisnik = dgvZaposlenici.CurrentRow.DataBoundItem as ZaposleniciView;
            AzurirajZaposlenikaForm form = new AzurirajZaposlenikaForm(odabraniKorisnik);
            form.ShowDialog();
            Osvjezi();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            string poruka = "Jeste li sigurni da želite obrisati odabranog korisnika?";
            string naslov = "Obriši korisnika";
            MessageBoxButtons tipke = MessageBoxButtons.YesNo;
            DialogResult rezultat = MessageBox.Show(poruka, naslov, tipke);
            if (rezultat == DialogResult.Yes)
            {
                ZaposleniciView odabraniZaposlenik = dgvZaposlenici.CurrentRow.DataBoundItem as ZaposleniciView;
                List<Korisnik> korisnici = new List<Korisnik>();
                korisnici = DohvatiSveKorisnike();
                Korisnik zaBrisanje = new Korisnik();
                using (var context = new PI2220_DBEntities())
                {
                    foreach (Korisnik korisnik in korisnici)
                    {
                        if (korisnik.id_korisnik == odabraniZaposlenik.IdZaposlenika)
                        {
                            zaBrisanje = korisnik;
                        }
                    }
                    context.Korisniks.Attach(zaBrisanje);
                    context.Korisniks.Remove(zaBrisanje);
                    context.SaveChanges();
                }
                Osvjezi();
            }
        }
        public List<Korisnik> DohvatiSveKorisnike()
        {
            using (var context = new PI2220_DBEntities())
            {
                return context.Korisniks.ToList();

            }
        }
    }
}
