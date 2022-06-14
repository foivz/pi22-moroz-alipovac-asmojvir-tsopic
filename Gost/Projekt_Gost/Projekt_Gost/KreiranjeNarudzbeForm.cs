using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Gost
{
    public partial class KreiranjeNarudzbeForm : Form
    {
        public Narudzba prosljedenaNarudzba;
        public List<stavka_narudzbe> stavke_narudzbe = new List<stavka_narudzbe>();
        
        
        

        public KreiranjeNarudzbeForm(Narudzba narudzba)
        {
            InitializeComponent();
            prosljedenaNarudzba = narudzba;
            dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMojaNarudzba.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void KreiranjeNarudzbeForm_Load(object sender, EventArgs e)
        {
            RefreshGUI();
            Fill_Vrste_artikla();
            comboBoxVrsteArtikla.SelectedItem = null;
        }

        private void Fill_Vrste_artikla()
        {
            using (var context = new PI2220_DBEntities())
            {
                var query = from va in context.Vrsta_artiklas
                            select va;
                comboBoxVrsteArtikla.DataSource = query.ToList();
            }
        }

        private void RefreshGUI()
        {
            using (var context = new PI2220_DBEntities())
            {
                var query = from a in context.Artikls.Include("Vrsta_artikla")
                            select a;
                dgvMenu.DataSource = query.ToList();
                dgvMenu.Columns["stavka_narudzbe"].Visible = false;
                dgvMenu.Columns["id_artikl"].Visible = false;
                dgvMenu.Columns["kolicina_u_skladistu"].Visible = false;
                dgvMenu.Columns["id_vrste_artikla"].Visible = false;
            }
        }

        private void buttonFiltriraj_Click(object sender, EventArgs e)
        {
            string naziv = comboBoxVrsteArtikla.Text;
            using (var context = new PI2220_DBEntities())
            {
                var query = from a in context.Artikls
                            join b in context.Vrsta_artiklas on a.id_vrste_artikla equals b.id_vrste_artikla
                            where b.naziv_vrste_artikla == naziv.ToString()
                            select a;

                dgvMenu.DataSource = query.ToList();
                dgvMenu.Columns["stavka_narudzbe"].Visible = false;
                dgvMenu.Columns["id_artikl"].Visible = false;
                dgvMenu.Columns["kolicina_u_skladistu"].Visible = false;
                dgvMenu.Columns["id_vrste_artikla"].Visible = false;
                dgvMenu.Columns["Vrsta_artikla"].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshGUI();
            dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string naziv = textBox1.Text;
            using (var context = new PI2220_DBEntities())
            {
                var query = from a in context.Artikls.Include("Vrsta_artikla")
                            where a.naziv_artikla.Contains(naziv)
                            select a;

                dgvMenu.DataSource = query.ToList();
                dgvMenu.Columns["stavka_narudzbe"].Visible = false;
                dgvMenu.Columns["id_artikl"].Visible = false;
                dgvMenu.Columns["kolicina_u_skladistu"].Visible = false;
                dgvMenu.Columns["id_vrste_artikla"].Visible = false;

            }
        }


        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            double ukupno=0;
            double suma=0;
            Artikl artikl = new Artikl();
            artikl = dgvMenu.CurrentRow.DataBoundItem as Artikl;
            int kolicina = int.Parse(textBoxKolicina.Text);
            stavka_narudzbe stavka_narudzbe = new stavka_narudzbe();
            stavka_narudzbe.id_artikl = artikl.id_artikl;
            stavka_narudzbe.kolicina = kolicina;
            stavka_narudzbe.id_narudzba = prosljedenaNarudzba.id_narudzba;
            using (var context = new PI2220_DBEntities())
            {
                context.stavka_narudzbe.Add(stavka_narudzbe);
                context.SaveChanges();

            }
            using(var context = new PI2220_DBEntities())
            {
                
                var query = from sn in context.stavka_narudzbe
                            join ar in context.Artikls on sn.id_artikl equals ar.id_artikl
                            where sn.id_narudzba.Equals(prosljedenaNarudzba.id_narudzba)
                            select new {ar.naziv_artikla,ar.cijena,sn.kolicina};
                dgvMojaNarudzba.DataSource = query.ToList();
                foreach (DataGridViewRow row in dgvMojaNarudzba.Rows )
                {
                    suma = double.Parse(row.Cells[1].Value.ToString()) * double.Parse(row.Cells[2].Value.ToString());
                    ukupno = ukupno + suma;

                }
                
                textBoxUkupno.Text = $"{ukupno.ToString()} HRK";
               

            }
           




        
       }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            using(var context= new PI2220_DBEntities())
            {
                context.stavka_narudzbe.RemoveRange(context.stavka_narudzbe.Where(x => x.id_narudzba == prosljedenaNarudzba.id_narudzba));
                context.SaveChanges();
            }

            using(var context = new PI2220_DBEntities())
            {

                context.Narudzbas.RemoveRange(context.Narudzbas.Where(x => x.id_narudzba == prosljedenaNarudzba.id_narudzba));
                context.SaveChanges();
               
                
            }
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void buttonPotvrdiNarudzbu_Click(object sender, EventArgs e)
        {
            int brojRedova = dgvMojaNarudzba.Rows.Count;
            if(brojRedova > 0)
            {
                MessageBox.Show("Uspješno ste naručili!");
                Close();
            }
            else
            {
                MessageBox.Show("Niste dodali niti jednu stavku u Vašu narudžbu!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
            using (var context = new PI2220_DBEntities())
            {
                context.stavka_narudzbe.RemoveRange(context.stavka_narudzbe.Where(x => x.id_narudzba == prosljedenaNarudzba.id_narudzba));
                context.SaveChanges();
            }
            textBoxUkupno.Text = "";
            dgvMojaNarudzba.DataSource = null;



        }
    }
}
