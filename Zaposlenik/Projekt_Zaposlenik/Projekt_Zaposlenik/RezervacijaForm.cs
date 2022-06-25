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
    public partial class RezervacijaForm : Form
    {
        public RezervacijaForm()
        {
            InitializeComponent();
        }

        private void dgvRegistracija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegistracijaForm_Load(object sender, EventArgs e)
        {
            DohvatiRegistracije();
            cmbKorisnik.DataSource = DohvatiKorisnike();
        }

        private List<Korisnik> DohvatiKorisnike()
        {
            using (var context = new PI2220_DBEntities())
            {
                return context.Korisniks.ToList();
            }
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
                                Odobreno = r.odobrena
                            };
                dgvRegistracija.DataSource = query.ToList();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (var context = new PI2220_DBEntities())
            {
                string email = txtEmail.Text;
                string ime = txtIme.Text;
                string prezime =  txtPrezime.Text;
                string telefon = txtTelefon.Text;
                DateTime datumRezervacije = DateTime.Now;
                DateTime datumDogadaja = datePickDatum.Value;
                Korisnik dodao = cmbKorisnik.SelectedItem as Korisnik;
                context.Korisniks.Attach(dodao);
                Rezervacija novaRezervacija = new Rezervacija
                {
                    email_gosta = email,
                    ime = ime,
                    prezime = prezime,
                    tel_gosta = telefon,
                    datum_rezervacije = datumRezervacije,
                    datum_dogadaja = datumDogadaja,
                    id_dodao = dodao.id_korisnik,
                    odobrena = 0
                };
                context.Rezervacijas.Add(novaRezervacija);
                context.SaveChanges();
            }
            Close();
        }
    }
}
