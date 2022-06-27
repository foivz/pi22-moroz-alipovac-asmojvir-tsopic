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

        private void Dodavanje()
        {
            using (var context = new PI2220_DBEntities())
            {
                bool ispravno = true;
                List<Artikl> artikli = DohvatiPica();
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
                    Close();
                }
                else
                {
                    MessageBox.Show("Unijeli ste neispravne podatke!");
                }   
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Dodavanje();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        public List<Artikl> DohvatiPica()
        {
            using (var context = new PI2220_DBEntities())
            {
                return context.Artikls.ToList();                
            }
        }
    }
}
