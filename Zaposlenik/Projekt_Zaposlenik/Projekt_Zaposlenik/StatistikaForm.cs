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
    public partial class StatistikaForm : Form
    {
        public StatistikaForm()
        {
            InitializeComponent();
        }
        private void FillComboBox()
        {
            List<string> strings = new List<string>() { "Siječanj", "Veljača", "Ožujak", "Travanj", "Svibanj", "Lipanj", "Srpanj", "Kolovoz", "Rujan", "Listopad", "Studeni", "Prosinac" };
            comboBox1.DataSource = strings;
            comboBox1.SelectedIndex = DateTime.Now.Month - 1;
        }
        private async void RefreshGUI()
        {
            using (var context = new PI2220_DBEntities())
            {
                var query = from a in context.Artikls
                            join sn in context.stavka_narudzbe on a.id_artikl equals sn.id_artikl
                            join n in context.Narudzbas on sn.id_narudzba equals n.id_narudzba
                            where sn.id_artikl == a.id_artikl && n.datum_i_vrijeme.Month == DateTime.Now.Month
                            group sn.kolicina by new { a.naziv_artikla, a.Vrsta_artikla, a.cijena } into g
                            select new { Naziv = g.Key.naziv_artikla, Vrsta = g.Key.Vrsta_artikla, Cijena = g.Key.cijena, Prodano = g.Sum() };

                dataGridViewStatistika.DataSource = query.ToList();
                double promet = 0;
                foreach (DataGridViewRow row in dataGridViewStatistika.Rows)
                {
                    double prometArtikla = Convert.ToDouble(row.Cells[2].Value) * Convert.ToInt32(row.Cells[3].Value);
                    promet += prometArtikla;
                }
                textBoxPromet.Text = promet.ToString() + " KN";
            }
        }
        private async void RefreshGUIvol2(int index)
        {
            using (var context = new PI2220_DBEntities())
            {
                var query = from a in context.Artikls
                            join sn in context.stavka_narudzbe on a.id_artikl equals sn.id_artikl
                            join n in context.Narudzbas on sn.id_narudzba equals n.id_narudzba
                            where sn.id_artikl == a.id_artikl && n.datum_i_vrijeme.Month == index
                            group sn.kolicina by new { a.naziv_artikla, a.Vrsta_artikla, a.cijena } into g
                            select new { Naziv = g.Key.naziv_artikla, Vrsta = g.Key.Vrsta_artikla, Cijena = g.Key.cijena, Prodano = g.Sum() };

                dataGridViewStatistika.DataSource = query.ToList();
                double promet = 0;
                foreach (DataGridViewRow row in dataGridViewStatistika.Rows)
                {
                    double prometArtikla = Convert.ToDouble(row.Cells[2].Value) * Convert.ToInt32(row.Cells[3].Value);
                    promet += prometArtikla;
                }
                textBoxPromet.Text = promet.ToString() + " KN";
            }
        }

        private void StatistikaForm_Load(object sender, EventArgs e)
        {
            RefreshGUI();
            FillComboBox();
        }

        private void Odaberi()
        {
            int brojMjeseca = comboBox1.SelectedIndex + 1;
            RefreshGUIvol2(brojMjeseca);
        }

        private void buttonOdaberi_Click(object sender, EventArgs e)
        {
            Odaberi();
        }
    }
}
