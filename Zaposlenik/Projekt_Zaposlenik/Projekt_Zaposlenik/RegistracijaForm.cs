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
            DohvatiRegistracije();
            DohvatiKorisnike();
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
            DohvatiRegistracije();
        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {



        }
    }
}
