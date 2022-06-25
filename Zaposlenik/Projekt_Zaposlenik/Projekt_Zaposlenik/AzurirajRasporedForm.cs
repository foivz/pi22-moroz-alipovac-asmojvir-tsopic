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
    public partial class AzurirajRasporedForm : Form
    {
        public RasporedIspis Raspored;
        public AzurirajRasporedForm(RasporedIspis raspored)
        {
            InitializeComponent();
            Raspored = raspored;
        }

        private void AzurirajRasporedForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = Raspored.Dan;
            comboBoxKorisnik.DataSource = DohvatiKorisnike();
            comboBoxSmjena.DataSource = DohvatiSmjene();
        }

        private List<TipSmjene> DohvatiSmjene()
        {
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

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPrihvati_Click(object sender, EventArgs e)
        {

            Raspored raspored = new Raspored();
            List<Raspored> rasporedi = DohrvatiRasporede();

            using (var context = new PI2220_DBEntities())
            {
                foreach(Raspored r in rasporedi)
                {
                    if(r.id_raspored == Raspored.ID)
                    {
                        raspored = r;
                    }
                }

                DateTime dan = dateTimePicker1.Value;
                Korisnik korisnik = comboBoxKorisnik.SelectedItem as Korisnik;

                TipSmjene smjene = comboBoxSmjena.SelectedItem as TipSmjene;

                context.Rasporeds.Attach(raspored);
                raspored.radni_dan = dan;
                raspored.id_smjena = smjene.id_tip_smjene;
                raspored.id_zaposlenik = korisnik.id_korisnik;
                context.SaveChanges();
            }
            Close();

        }

        private List<Raspored> DohrvatiRasporede()
        {
            using(var context = new PI2220_DBEntities())
            {
                var upit = from r in context.Rasporeds
                           select r;
                return upit.ToList();
            }
        }
    }
}
