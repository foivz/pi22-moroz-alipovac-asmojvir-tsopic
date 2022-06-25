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
    public partial class RegistracijaForm : Form
    {
        public RegistracijaForm()
        {
            InitializeComponent();
        }

        private void dgvRegistracija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegistracijaForm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            dgvRegistracija.DataSource = DohvatiRegistracije();
            dgvRegistracija.Columns["id_rezervacije"].Visible = false;
            dgvRegistracija.Columns["Korisnik1"].Visible = false;
            dgvRegistracija.Columns["Korisnik"].Visible = false;
        }

        private object DohvatiRegistracije()
        {
            using (var context = new PI2220_DBEntities())
            {
                return context.Rezervacijas.ToList();
            }
        }
    }
}
