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
    public partial class AzurirajArtiklForm : Form
    {
        public Artikl odabraniArtikl;
        public AzurirajArtiklForm(Artikl artikl)
        {
            InitializeComponent();
            Fill_Vrste_artikla();
            odabraniArtikl = artikl;
        }
        private void Fill_Vrste_artikla()
        {
            using (var context = new PI2220_DBEntities())
            {
                var query = from va in context.Vrsta_artiklas
                            select va;
                comboBoxVrsta.DataSource = query.ToList();
            }
        }

        private void AzurirajArtiklForm_Load(object sender, EventArgs e)
        {
            textBoxArtikl.Text = odabraniArtikl.naziv_artikla;
            textBoxKolicina.Text = odabraniArtikl.kolicina_u_litrama.ToString();
            textBoxCijena.Text = odabraniArtikl.cijena.ToString();
            textBoxSkladiste.Text = odabraniArtikl.kolicina_u_skladistu.ToString();
            comboBoxVrsta.Text = odabraniArtikl.Vrsta_artikla.ToString();
        }

        private void buttonAzuriraj_Click(object sender, EventArgs e)
        {
            using (var context = new PI2220_DBEntities())
            {
                Vrsta_artikla vrsta = comboBoxVrsta.SelectedItem as Vrsta_artikla;
                var item = context.Artikls.SingleOrDefault(i => i.id_artikl == odabraniArtikl.id_artikl);
                item.naziv_artikla = textBoxArtikl.Text;
                item.kolicina_u_litrama = double.Parse(textBoxKolicina.Text);
                item.kolicina_u_skladistu = int.Parse(textBoxSkladiste.Text);
                item.id_vrste_artikla = vrsta.id_vrste_artikla;
                item.cijena = double.Parse(textBoxCijena.Text);
                context.SaveChanges();
            }
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
