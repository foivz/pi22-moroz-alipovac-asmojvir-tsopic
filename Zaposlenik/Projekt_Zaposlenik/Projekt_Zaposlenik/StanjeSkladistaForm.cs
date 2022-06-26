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
    public partial class StanjeSkladistaForm : Form
    {
        public StanjeSkladistaForm()
        {
            InitializeComponent();
        }

        private void StanjeSkladistaForm_Load(object sender, EventArgs e)
        {
            using(var context = new PI2220_DBEntities())
            {
                var upit = from a in context.Artikls
                           select a;
                List<Artikl> artikls = upit.ToList();
                artiklBindingSource.DataSource = artikls;
            }
            this.reportViewer.RefreshReport();
        }
    }
}
