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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string korisnickoime = textBoxKorisnickoIme.Text;
            string lozinka = textBoxLozinka.Text;
            List<Korisnik> korisnici = new List<Korisnik>();
            Korisnik pronadeniKorisnik = new Korisnik();
            korisnici = DohvatiKorisnike();
            bool pronaden = false;
            foreach(Korisnik korisnik in korisnici)
            {
                if(korisnik.korisnicko_ime == korisnickoime && korisnik.lozinka == lozinka)
                {
                    pronaden = true;
                    pronadeniKorisnik = korisnik;
                    break;
                }
            }
            if(pronaden == true)
            {
                GlavniIzbornikForm form = new GlavniIzbornikForm(pronadeniKorisnik);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Krivo uneseni podaci!");
            }

        }

        public List<Korisnik> DohvatiKorisnike()
        {
            using(var context = new PI2220_DBEntities())
            {
                return context.Korisniks.ToList();

            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
