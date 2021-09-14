using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoTechFull.WinUI.Artikli;
using MoTechFull.WinUI.Gradovi;
using MoTechFull.WinUI.Kantoni;
using MoTechFull.WinUI.Kategorije;
using MoTechFull.WinUI.KorisnickiNalozi;
using MoTechFull.WinUI.Proizvodjaci;
using MoTechFull.WinUI.Shop;

namespace MoTechFull.WinUI
{
    public partial class frmPocetna : Form
    {
        private int childFormNumber = 0;

        public frmPocetna()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        //private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        //}

        //private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        //}

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazArtikala frm = new frmPrikazArtikala();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArtikliDodajUredi frm = new frmArtikliDodajUredi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnickiNaloziPrikazi frm = new frmKorisnickiNaloziPrikazi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajUrediKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnickiNaloziDodajUredi frm = new frmKorisnickiNaloziDodajUredi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledKategorijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKategorijePrikazi frm = new frmKategorijePrikazi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajUrediKategorijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKategorijeDodajUredi frm = new frmKategorijeDodajUredi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledProizvodjacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProizvodjaciPrikazi frm = new frmProizvodjaciPrikazi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajUrediProizvodjacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProizvodjaciDodajUredi frm = new frmProizvodjaciDodajUredi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledKantonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKantoniPregled frm = new frmKantoniPregled();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajUrediKantonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKantoniDodajUredi frm = new frmKantoniDodajUredi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledGradovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGradoviPregled frm = new frmGradoviPregled();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajUrediGradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGradoviDodajUredi frm = new frmGradoviDodajUredi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sHOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShop frm = new frmShop();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
