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

        }
    }
}
