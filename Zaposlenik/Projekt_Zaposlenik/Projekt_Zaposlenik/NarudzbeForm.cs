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
    public partial class NarudzbeForm : Form
    {
        Korisnik korisnik = new Korisnik();
        public NarudzbeForm(Korisnik prosljedeniKorisnik)
        {
            InitializeComponent();
            korisnik = prosljedeniKorisnik;
            dgvNarudzbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void NarudzbeForm_Load(object sender, EventArgs e)
        {
            DohvatiPodatkeONarudzbama();
        }

        public void DohvatiPodatkeONarudzbama()
        {
            using(var context=new PI2220_DBEntities())
            {
                var query = from n in context.Narudzbas
                            join sn in context.Status_narudzbes on n.id_statusa_narudzbe equals sn.id_status_narudzbe

                            select new { n.id_narudzba, n.id_stola, n.datum_i_vrijeme, sn.naziv_statusa_narudzbe };

                dgvNarudzbe.DataSource = query.ToList();
                
                dgvNarudzbe.Columns[0].HeaderText = "Broj narudžbe";
                dgvNarudzbe.Columns[1].HeaderText = "Broj stola";
                dgvNarudzbe.Columns[2].HeaderText = "Vrijeme narudžbe";
                dgvNarudzbe.Columns[3].HeaderText = "Status narudžbe";
                
            }
            foreach(DataGridViewRow row in dgvNarudzbe.Rows)
            {
                if (row.Cells[3].Value.ToString() == "U tijeku")
                {
                    row.Cells[3].Style.BackColor = Color.Red;
                }
                else
                {
                    row.Cells[3].Style.BackColor = Color.Green;
                }
            }
        }

        private void buttonPosluzi_Click(object sender, EventArgs e)
        {
            if (dgvNarudzbe.CurrentRow.Cells[3].Value.ToString()=="U tijeku") {
                int brojnarudzbe = Convert.ToInt32(dgvNarudzbe.CurrentRow.Cells[0].Value);
                int brojstola = Convert.ToInt32(dgvNarudzbe.CurrentRow.Cells[1].Value);
                PosluziForm form = new PosluziForm(brojnarudzbe, brojstola, korisnik);
                form.ShowDialog();
                using (var context = new PI2220_DBEntities())
                {
                    var query = from n in context.Narudzbas
                                join sn in context.Status_narudzbes on n.id_statusa_narudzbe equals sn.id_status_narudzbe

                                select new { n.id_narudzba, n.id_stola, n.datum_i_vrijeme, sn.naziv_statusa_narudzbe };

                    dgvNarudzbe.DataSource = query.ToList();

                    dgvNarudzbe.Columns[0].HeaderText = "Broj narudžbe";
                    dgvNarudzbe.Columns[1].HeaderText = "Broj stola";
                    dgvNarudzbe.Columns[2].HeaderText = "Vrijeme narudžbe";
                    dgvNarudzbe.Columns[3].HeaderText = "Status narudžbe";

                }
                foreach (DataGridViewRow row in dgvNarudzbe.Rows)
                {
                    if (row.Cells[3].Value.ToString() == "U tijeku")
                    {
                        row.Cells[3].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        row.Cells[3].Style.BackColor = Color.Green;
                    }
                }
            }
            else
            {
                MessageBox.Show("Odabrali ste već posluženu narudžbu!");
            }
            
            

        }
    }
}
