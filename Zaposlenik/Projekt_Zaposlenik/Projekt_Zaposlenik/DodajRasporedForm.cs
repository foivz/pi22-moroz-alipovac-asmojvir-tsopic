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
    public partial class DodajRasporedForm : Form
    {
        public DodajRasporedForm()
        {
            InitializeComponent();
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private List<TipSmjene> DohvatiSmjene() {
            using (var context = new PI2220_DBEntities())
            {
                var upit = from t in context.TipSmjenes
                           select t;
                return upit.ToList();
            }    
        }

        private List<Korisnik> DohvatiKorisnike()
        {
            using (var context = new PI2220_DBEntities())
            {
                var upit = from k in context.Korisniks
                           select k;
                return upit.ToList();
            }
        }

        private void DodajRasporedForm_Load(object sender, EventArgs e)
        {
            comboBoxKorisnik.DataSource = DohvatiKorisnike();
            comboBoxSmjena.DataSource = DohvatiSmjene();
        }

        private void buttonPrihvati_Click(object sender, EventArgs e)
        {

            using (var context =new PI2220_DBEntities())
            {
                DateTime dan = dateTimePicker1.Value;
                Korisnik korisnik = comboBoxKorisnik.SelectedItem as Korisnik;
             
                TipSmjene smjene = comboBoxSmjena.SelectedItem as TipSmjene;

                Raspored raspored = new Raspored
                {
                    radni_dan = dan,
                    id_smjena = smjene.id_tip_smjene,
                    id_zaposlenik = korisnik.id_korisnik
                };
                context.Rasporeds.Add(raspored);
                context.SaveChanges();
            }
            Close();

        }
    }
}
