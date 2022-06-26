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
    public partial class ProvjeraBrisanjaForm : Form
    {
        public bool ispravno = false;
        RegistracijaView OdabranaRezervacija = new RegistracijaView();
        public ProvjeraBrisanjaForm(RegistracijaView odabranaRezervacija)
        {
            InitializeComponent();
            OdabranaRezervacija = odabranaRezervacija;
        }

        private void ProvjeraBrisanjaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            string lozinka = txtLozinka.Text;
            List<Korisnik> korisnici = new List<Korisnik>();
            korisnici = DohvatiKorisnike();
            List<Rezervacija> rezervacije = new List<Rezervacija>();
            rezervacije = DohvatiRezervacije();
            Rezervacija novaRezervacija = new Rezervacija();
            foreach (Korisnik korisnik in korisnici)
            {
                if (korisnik.lozinka == lozinka)
                {
                    if (korisnik.id_uloga == 3 || korisnik.id_uloga == 2)
                    {
                        ispravno = true;
                    }
                }
            }
            if (ispravno == true)
            {
                using (var context = new PI2220_DBEntities())
                {
                    foreach (Rezervacija rezervacija in rezervacije)
                    {
                        if (rezervacija.id_rezervacije == OdabranaRezervacija.Id_rezervacije)
                        {
                            novaRezervacija = rezervacija;
                        }
                    }
                    context.Rezervacijas.Attach(novaRezervacija);
                    context.Rezervacijas.Remove(novaRezervacija);
                    context.SaveChanges();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Krivo uneseni podaci!");
            }
        }
        public List<Korisnik> DohvatiKorisnike()
        {
            using (var context = new PI2220_DBEntities())
            {
                return context.Korisniks.ToList();

            }
        }
        public List<Rezervacija> DohvatiRezervacije()
        {
            using (var context = new PI2220_DBEntities())
            {
                return context.Rezervacijas.ToList();

            }
        }
    }
}
