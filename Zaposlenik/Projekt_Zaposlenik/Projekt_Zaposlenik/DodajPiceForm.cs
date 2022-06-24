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
    public partial class DodajPiceForm : Form
    {
        public DodajPiceForm()
        {
            InitializeComponent();
        }

        private void DodajPiceForm_Load(object sender, EventArgs e)
        {
            Fill_Vrste_artikla();
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

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            using (var context = new PI2220_DBEntities())
            {
                string artikl = textBoxArtikl.Text;
                double kolicinaL = double.Parse(textBoxKolicina.Text);
                int kolicinaSkladiste = int.Parse(textBoxSkladiste.Text);
                Vrsta_artikla vrsta = comboBoxVrsta.SelectedItem as Vrsta_artikla;
                double cijena = double.Parse(textBoxCijena.Text);

                Artikl noviArtikl = new Artikl()
                {
                    id_artikl = default,
                    naziv_artikla = artikl,
                    kolicina_u_litrama = kolicinaL,
                    kolicina_u_skladistu = kolicinaSkladiste,
                    cijena = cijena,
                    id_vrste_artikla = vrsta.id_vrste_artikla
                };
                context.Artikls.Add(noviArtikl);
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
