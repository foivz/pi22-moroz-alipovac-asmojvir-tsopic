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
        public ArtiklView odabraniArtikl;
        private void Fill_Vrste_artikla()
        {
            using (var context = new PI2220_DBEntities())
            {
                var query = from va in context.Vrsta_artiklas
                            select va;
                comboBoxVrsta.DataSource = query.ToList();
            }
        }
        public AzurirajArtiklForm(ArtiklView artikl)
        {
            InitializeComponent();
            Fill_Vrste_artikla();
            odabraniArtikl = artikl;
        }

        private void AzurirajArtiklForm_Load(object sender, EventArgs e)
        {
            textBoxArtikl.Text = odabraniArtikl.naziv;
            textBoxKolicina.Text = odabraniArtikl.kolicinaL.ToString();
            textBoxCijena.Text = odabraniArtikl.cijena.ToString();
            textBoxSkladiste.Text = odabraniArtikl.skladiste.ToString();
            comboBoxVrsta.Text = odabraniArtikl.vrsta;
        }

        private void Azuriranje()
        {
            using (var context = new PI2220_DBEntities())
            {
                bool ispravno = true;
                string artikl;
                if (textBoxArtikl.Text != "")
                    artikl = textBoxArtikl.Text;
                else artikl = null;
                if (artikl == null) ispravno = false;
                double kolicinaL;
                bool isDouble = Double.TryParse(textBoxKolicina.Text, out kolicinaL);
                if (isDouble)
                {
                    kolicinaL = double.Parse(textBoxKolicina.Text);
                    if (kolicinaL <= 0)
                        ispravno = false;
                }
                else
                {
                    ispravno = false;
                }
                int kolicinaSkladiste;
                bool isInt = Int32.TryParse(textBoxSkladiste.Text, out kolicinaSkladiste);
                if (isInt)
                {
                    kolicinaSkladiste = Int32.Parse(textBoxSkladiste.Text);
                    if (kolicinaSkladiste <= 0)
                        ispravno = false;
                }
                else
                {
                    ispravno = false;
                }
                Vrsta_artikla vrsta = comboBoxVrsta.SelectedItem as Vrsta_artikla;
                double cijena;
                bool isDouble2 = Double.TryParse(textBoxCijena.Text, out cijena);
                if (isDouble2)
                {
                    cijena = double.Parse(textBoxCijena.Text);
                    if (cijena < 0)
                        ispravno = false;
                }
                else
                {
                    ispravno = false;
                }
                if (ispravno)
                {
                    var item = context.Artikls.SingleOrDefault(i => i.id_artikl == odabraniArtikl.ArtiklId);
                    item.naziv_artikla = artikl;
                    item.kolicina_u_litrama = kolicinaL;
                    item.kolicina_u_skladistu = kolicinaSkladiste;
                    item.id_vrste_artikla = vrsta.id_vrste_artikla;
                    item.cijena = cijena;
                    context.SaveChanges();
                    Close();
                }
                else
                {
                    MessageBox.Show("Unijeli ste neispravne podatke!");
                }
                
            }
        }

        private void buttonAzuriraj_Click(object sender, EventArgs e)
        {
            Azuriranje();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
