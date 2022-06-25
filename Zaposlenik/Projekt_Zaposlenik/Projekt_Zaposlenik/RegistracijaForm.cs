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
    public partial class RegistracijaForm : Form
    {
        public RegistracijaForm()
        {
            InitializeComponent();
        }

        private void dgvRegistracija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegistracijaForm_Load(object sender, EventArgs e)
        {
            Osjvezi();
        }

        private void Osjvezi()
        {
            DohvatiRegistracije();
            DohvatiKorisnike();
            foreach (DataGridViewRow row in dgvRegistracija.Rows)
            {
                if (row.Cells[7].Value.ToString() == "0")
                {
                    row.Cells[7].Style.BackColor = Color.Red;
                }
                else
                {
                    row.Cells[7].Style.BackColor = Color.Green;
                }
            }
        }

        private void DohvatiKorisnike()
        {
            using (var context = new PI2220_DBEntities())
            {
                var query = from k in context.Korisniks
                            select k;
                cmbDodao.DataSource = query.ToList();
            } ;
        }

        private void DohvatiRegistracije()
        {
            using (var context = new PI2220_DBEntities())
            {
                var query = from r in context.Rezervacijas.Include("Korisnik").Include("Korisnik1")
                            select new RegistracijaView
                            {
                                Id_rezervacije= r.id_rezervacije,
                                Gost = r.ime +" "+ r.prezime,
                                Email = r.email_gosta,
                                Telefon = r.tel_gosta,
                                DatumRezervacije = r.datum_rezervacije,
                                DatumDogadaja = r.datum_dogadaja,
                                Dodao = r.Korisnik.ime + " " + r.Korisnik.prezime,
                                Odobreno = r.odobrena,
                                Opis = r.opis_dogadaja
                            };
                dgvRegistracija.DataSource = query.ToList();
                dgvRegistracija.Columns[0].HeaderText = "Broj rezervacije";
                dgvRegistracija.Columns[1].HeaderText = "Gost";
                dgvRegistracija.Columns[2].HeaderText = "Email";
                dgvRegistracija.Columns[3].HeaderText = "Telefon";
                dgvRegistracija.Columns[4].HeaderText = "Datum rezervacije";
                dgvRegistracija.Columns[5].HeaderText = "Datum događaja";
                dgvRegistracija.Columns[6].HeaderText = "Dodao";
                dgvRegistracija.Columns[7].HeaderText = "Odobreno";
            }
        }

        public List<Rezervacija> DohvatiRezervacije()
        {
            using (var context = new PI2220_DBEntities())
            {
                return context.Rezervacijas.ToList();

            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
            string poruka = "";
            bool greskaDatum = false;
            List<Rezervacija> rezervacije = new List<Rezervacija>();
            rezervacije = DohvatiRezervacije();

            using (var context = new PI2220_DBEntities())
            {
                string email= txtEmail.Text;
                string ime = txtIme.Text;
                string prezime = txtPrezime.Text;
                string telefon = txtTelefon.Text;
                DateTime datumDogadaja = datePickDatum.Value.Date;
                Korisnik unositelj = cmbDodao.SelectedItem as Korisnik;
                string opis = txtOpis.Text;

                foreach (Rezervacija rezervacija in rezervacije)
                {
                    if (datumDogadaja == rezervacija.datum_dogadaja.Date)
                    {
                        greskaDatum=true;
                    }
                }

                if(ime=="" || prezime=="" || (telefon=="" && email == "") || opis == "")
                {
                    poruka = "Ispunite sva polja.";
                }
                else if (greskaDatum == true)
                {
                    poruka = "Datum koji ste odabrali već je zauzet.";
                }
                else
                {
                    Rezervacija novaRezervacija = new Rezervacija()
                    {
                        id_rezervacije = default,
                        email_gosta = email,
                        tel_gosta = telefon,
                        ime = ime,
                        prezime = prezime,
                        datum_rezervacije = DateTime.Now,
                        odobrena = 0,
                        id_dodao = unositelj.id_korisnik,
                        datum_dogadaja = datumDogadaja,
                        opis_dogadaja = opis
                    };
                    context.Rezervacijas.Add(novaRezervacija);
                    context.SaveChanges();
                    poruka = "Uspješno dodana rezervacija.";
                }

            }
            MessageBox.Show(poruka);
            txtEmail.Text = "";
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtTelefon.Text = "";
            txtOpis.Text = "";
            datePickDatum.Value = DateTime.Now;
            Osjvezi();
        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {
            RegistracijaView odabranaRezervacija = dgvRegistracija.CurrentRow.DataBoundItem as RegistracijaView;
            if (odabranaRezervacija.Odobreno==0)
            {
                Provjera provjera = new Provjera(odabranaRezervacija);
                provjera.ShowDialog();
                Osjvezi();
            }
            else
            {
                MessageBox.Show("Rezervacija već odobrena");
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            string poruka = "Jeste li sigurni da želite obrisati odabranu rezervaciju?";
            string naslov = "Obriši rezervaciju";
            MessageBoxButtons tipke = MessageBoxButtons.YesNo;
            DialogResult rezultat = MessageBox.Show(poruka, naslov, tipke);
            if (rezultat == DialogResult.Yes)
            {
                RegistracijaView odabranaRezervacija = dgvRegistracija.CurrentRow.DataBoundItem as RegistracijaView;
                List<Rezervacija> rezervacije = new List<Rezervacija>();
                rezervacije = DohvatiRezervacije();
                Rezervacija novaRezervacija = new Rezervacija();
                using (var context = new PI2220_DBEntities())
                {
                    foreach (Rezervacija rezervacija in rezervacije)
                    {
                        if (rezervacija.id_rezervacije == odabranaRezervacija.Id_rezervacije)
                        {
                            novaRezervacija = rezervacija;
                        }
                    }
                    context.Rezervacijas.Attach(novaRezervacija);
                    context.Rezervacijas.Remove(novaRezervacija);
                    context.SaveChanges();
                }
                Osjvezi();
            }
        }
    }
}
