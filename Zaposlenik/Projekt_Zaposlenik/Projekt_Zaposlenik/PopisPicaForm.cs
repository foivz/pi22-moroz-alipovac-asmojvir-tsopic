using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Projekt_Zaposlenik
{
    public partial class PopisPicaForm : Form
    {
        Korisnik trenutniKorisnik;
        public PopisPicaForm(Korisnik korisnik)
        {
            trenutniKorisnik = korisnik;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PopisPicaForm_Load(object sender, EventArgs e)
        {
            RefreshGUI();
            Fill_Vrste_artikla();
            comboBoxVrsteArtikla.SelectedItem = null;
            if (trenutniKorisnik.id_uloga == 1)
            {
                buttonAzuriraj.Enabled = false;
                buttonDodaj.Enabled = false;
                buttonObrisi.Enabled = false;
            }
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
                var query = from a in context.Artikls.Include("Vrsta_artikla").Include("stavka_narudzbe")
                            select new ArtiklView
                            {
                                ArtiklId = a.id_artikl,
                                naziv = a.naziv_artikla,
                                cijena = a.cijena,
                                kolicinaL = a.kolicina_u_litrama,
                                skladiste = a.kolicina_u_skladistu,
                                vrsta = a.Vrsta_artikla.naziv_vrste_artikla
                            };
                dataGridViewPopis.DataSource = query.ToList();
            }
        }

        private void Filtriranje()
        {
            string naziv = comboBoxVrsteArtikla.Text;
            if (naziv != "")
            {
                using (var context = new PI2220_DBEntities())
                {
                    var query = from a in context.Artikls.Include("Vrsta_artikla").Include("stavka_narudzbe")
                                join b in context.Vrsta_artiklas on a.id_vrste_artikla equals b.id_vrste_artikla
                                where b.naziv_vrste_artikla == naziv.ToString()
                                select new ArtiklView
                                {
                                    ArtiklId = a.id_artikl,
                                    naziv = a.naziv_artikla,
                                    cijena = a.cijena,
                                    kolicinaL = a.kolicina_u_litrama,
                                    skladiste = a.kolicina_u_skladistu,
                                    vrsta = a.Vrsta_artikla.naziv_vrste_artikla
                                };

                    dataGridViewPopis.DataSource = query.ToList();
                }
            }
            else
            {
                using (var context = new PI2220_DBEntities())
                {
                    var query = from a in context.Artikls.Include("Vrsta_artikla").Include("stavka_narudzbe")
                                join b in context.Vrsta_artiklas on a.id_vrste_artikla equals b.id_vrste_artikla
                                select new ArtiklView
                                {
                                    ArtiklId = a.id_artikl,
                                    naziv = a.naziv_artikla,
                                    cijena = a.cijena,
                                    kolicinaL = a.kolicina_u_litrama,
                                    skladiste = a.kolicina_u_skladistu,
                                    vrsta = a.Vrsta_artikla.naziv_vrste_artikla
                                };

                    dataGridViewPopis.DataSource = query.ToList();
                }
            }
        }

        private void buttonFiltriraj_Click(object sender, EventArgs e)
        {
            Filtriranje();
        }

        private void Pretraga()
        {
            string naziv = textBoxPretraga.Text;
            string vrsta = comboBoxVrsteArtikla.Text;
            using (var context = new PI2220_DBEntities())
            {
                var query = from a in context.Artikls.Include("Vrsta_artikla")
                            where a.naziv_artikla.Contains(naziv)
                            select new ArtiklView
                            {
                                ArtiklId = a.id_artikl,
                                naziv = a.naziv_artikla,
                                cijena = a.cijena,
                                kolicinaL = a.kolicina_u_litrama,
                                skladiste = a.kolicina_u_skladistu,
                                vrsta = a.Vrsta_artikla.naziv_vrste_artikla
                            };

                dataGridViewPopis.DataSource = query.ToList();
            }
        }

        private void textBoxPretraga_TextChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void Brisanje() { 
            DialogResult dr = MessageBox.Show("Jeste li sigurni da želite obrisati odabrani artikl?", "Upozorenje", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                ArtiklView artikl = dataGridViewPopis.CurrentRow.DataBoundItem as ArtiklView;
                using (var context = new PI2220_DBEntities())
                {
                    List<Artikl> artikli = DohvatiPica();
                    Artikl noviArtikl = new Artikl();
                    foreach (Artikl item in artikli)
                    {
                        if (item.id_artikl == artikl.ArtiklId) noviArtikl = item;
                    }
                    context.Artikls.Attach(noviArtikl);
                    context.Artikls.Remove(noviArtikl);
                    context.SaveChanges();
                }
                RefreshGUI();
            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            Brisanje();
        }

        private void Dodavanje()
        {
            DodajPiceForm form = new DodajPiceForm();
            form.ShowDialog();
            RefreshGUI();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Dodavanje();
        }

        private void Azuriranje()
        {
            ArtiklView artikl = dataGridViewPopis.CurrentRow.DataBoundItem as ArtiklView;
            AzurirajArtiklForm form = new AzurirajArtiklForm(artikl);
            form.ShowDialog();
            RefreshGUI();
        }

        private void buttonAzuriraj_Click(object sender, EventArgs e)
        {
            Azuriranje();
        }

        public void ExportToPDF(DataGridView dgw, string fileName)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfTable = new PdfPTable(dgw.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 90;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = fileName;
            saveFileDialog.DefaultExt = ".pdf";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4,10f,10f,10f,0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {
            dataGridViewPopis.Columns.Remove("stavka_narudzbe");
            ExportToPDF(dataGridViewPopis, "Cjenik");
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
