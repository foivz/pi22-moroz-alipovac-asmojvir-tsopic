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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonNaruci_Click(object sender, EventArgs e)
        {
            Narudzba narudzba = new Narudzba();
            narudzba.id_stola = int.Parse(textBox1.Text);
            narudzba.datum_i_vrijeme = DateTime.Now;
            using(var context = new PI2220_DBEntities())
            {
                context.Narudzbas.Add(narudzba);
                context.SaveChanges();
            }
            KreiranjeNarudzbeForm form = new KreiranjeNarudzbeForm(narudzba);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
