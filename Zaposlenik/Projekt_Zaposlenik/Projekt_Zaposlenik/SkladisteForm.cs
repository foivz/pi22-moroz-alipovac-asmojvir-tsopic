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
    public partial class SkladisteForm : Form
    {
        public SkladisteForm()
        {
            InitializeComponent();
        }

        private void SkladisteForm_Load(object sender, EventArgs e)
        {
            using(var context = new PI2220_DBEntities())
            {
                var upit = from s in context.Artikls
                           select new Skladiste
                           {
                               ID = s.id_artikl,
                               Vrsta = s.Vrsta_artikla.naziv_vrste_artikla,
                               Naziv = s.naziv_artikla,
                               Kolicina = s.kolicina_u_skladistu,
                               Cijena = s.cijena
                           };

                dataGridViewSkladiste.DataSource = upit.ToList();
            }

            textBoxID.Text = "";
            textBoxKolicina.Text = "";
            
        }

        private void buttonProvjeri_Click(object sender, EventArgs e)
        {

            int id;
            int kolicina;
            
            Artikl artikl = new Artikl();
            
            


            if (textBoxID.Text == "" || textBoxKolicina.Text == "")
            {
                MessageBox.Show("Popunite prazna polja!");
                id = 0;
                kolicina = 0;

            }
            else
            {
                id = int.Parse(textBoxID.Text);
                kolicina = int.Parse(textBoxKolicina.Text);




                using (var context = new PI2220_DBEntities())
                {

                    var upit = from a in context.Artikls
                               select a;


                    List<Artikl> artikli = upit.ToList();

                    foreach (Artikl a in artikli)
                    {
                        if (id == a.id_artikl)
                        {
                            artikl = a;
                        }

                    }


                }


                if (id != artikl.id_artikl)
                {
                    MessageBox.Show("Ne postoji taj artikl na skladistu!");
                }
                else
                {
                    if (kolicina == artikl.kolicina_u_skladistu)
                    {
                        MessageBox.Show("Stanje u sustavu se podudara s unesenom količinom!");
                    }
                    else if (kolicina > artikl.kolicina_u_skladistu)
                    {
                        int razlika = kolicina - artikl.kolicina_u_skladistu;
                        MessageBox.Show($"Stanje u sustavu se ne podudara, unesena količina je veća za {razlika} komada!");
                    }
                    else
                    {
                        int razlika = artikl.kolicina_u_skladistu - kolicina;
                        MessageBox.Show($"Stanje u sustavu se ne podudara, unesena količina je manja za {razlika} komada!");
                    }
                }
            }
        }

        private void buttonPrikazIzvjestaja_Click(object sender, EventArgs e)
        {
            StanjeSkladistaForm stanjeSkladista = new StanjeSkladistaForm();
            stanjeSkladista.ShowDialog();
        }
    }
}
