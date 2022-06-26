﻿using System;
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
    public partial class SviZaposleniciIzvjestajForm : Form
    {
        public SviZaposleniciIzvjestajForm()
        {
            InitializeComponent();
        }

        private void SviZaposleniciIzvjestajForm_Load(object sender, EventArgs e)
        {
            using (var context = new PI2220_DBEntities())
            {
                var query = from k in context.Korisniks
                            select k;

                List<Korisnik> sviKorisnici = query.ToList();
                korisnikBindingSource.DataSource = sviKorisnici;
            }
                this.reportViewer.RefreshReport();
        }
    }
}
