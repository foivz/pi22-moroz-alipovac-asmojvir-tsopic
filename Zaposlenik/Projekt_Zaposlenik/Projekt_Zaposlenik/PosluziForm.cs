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
    public partial class PosluziForm : Form
    {
        public int prosljedeniBrojNarudzbe;
        public int prosljedeniBrojStola;
        public Korisnik korisnik = new Korisnik();
        public PosluziForm(int brojnarudzbe, int brojstola,Korisnik prosljedeniKorisnik)
        {
            prosljedeniBrojNarudzbe = brojnarudzbe;
            prosljedeniBrojStola = brojstola;
            korisnik = prosljedeniKorisnik;
            
            InitializeComponent();
        }
        private void DohvatiPodatkeOStavkamaOdabraneNarudzbe()
        {
            double ukupno = 0;
            double suma = 0;
            textBoxNarudzba.Text = prosljedeniBrojNarudzbe.ToString();
            textBoxBrojStola.Text = prosljedeniBrojStola.ToString();
            using (var context = new PI2220_DBEntities())
            {
                var query = from sn in context.stavka_narudzbe
                            join a in context.Artikls on sn.id_artikl equals a.id_artikl
                            where sn.id_narudzba.Equals(prosljedeniBrojNarudzbe)
                            select new
                            {
                                a.naziv_artikla,
                                a.cijena,
                                sn.kolicina
                            };
                dgvPosluzi.DataSource = query.ToList();
                dgvPosluzi.Columns[0].HeaderText = "Artikl";
                dgvPosluzi.Columns[1].HeaderText = "Cijena";
                dgvPosluzi.Columns[2].HeaderText = "Količina";
                foreach (DataGridViewRow row in dgvPosluzi.Rows)
                {
                    suma = double.Parse(row.Cells[1].Value.ToString()) * double.Parse(row.Cells[2].Value.ToString());
                    ukupno = ukupno + suma;
                }

                textBoxUkupno.Text = $"{ukupno.ToString()} HRK";
                dgvPosluzi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                dgvPosluzi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;


            }
        }

        private void PosluziForm_Load(object sender, EventArgs e)
        {
            DohvatiPodatkeOStavkamaOdabraneNarudzbe();
        }

        private void buttonIzdajRacun_Click(object sender, EventArgs e)
        {
            using (var context = new PI2220_DBEntities())
            {
                Racun racun = new Racun() { id_narudzba = prosljedeniBrojNarudzbe, datum_i_vrijeme = DateTime.Now, id_korisnik = korisnik.id_korisnik };
                context.Racuns.Add(racun);
                context.SaveChanges();
                    
             }

            using(var context = new PI2220_DBEntities())
            {

                Narudzba narudzba = context.Narudzbas.First(x => x.id_narudzba == prosljedeniBrojNarudzbe);
                context.Narudzbas.Attach(narudzba);
                narudzba.id_statusa_narudzbe = 2;
                context.SaveChanges();
            }
            Close();
        }
    }
}

