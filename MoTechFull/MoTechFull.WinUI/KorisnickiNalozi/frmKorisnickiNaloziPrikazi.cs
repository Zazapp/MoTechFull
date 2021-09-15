using MoTechFull.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoTechFull.WinUI.KorisnickiNalozi
{
    public partial class frmKorisnickiNaloziPrikazi : Form
    {

        APIService _service = new APIService("KorisnickiNalog");
        int tip;
        public frmKorisnickiNaloziPrikazi()
        {
            InitializeComponent();

            string a1 = "Administrator";
            string b1 = "Prodavac";
            string c1 = "Klijent";
            string d1 = "---";
            cmbTip.Items.Add(d1);
            cmbTip.Items.Add(a1);
            cmbTip.Items.Add(b1);
            cmbTip.Items.Add(c1);
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            KorisnickiNaloziSearchObject searchObject = new KorisnickiNaloziSearchObject
            {
                KorisnickoIme = txtIme.Text,
                Tip = tip
            };

            var list = await _service.Get<List<Model.KorisnickiNalozi>>(searchObject);
            dgvKorisnici.DataSource = list;
        }

        private void cmbTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            tip = cmbTip.SelectedIndex;
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvKorisnici.SelectedRows[0].DataBoundItem;
            frmKorisnickiNaloziDodajUredi frm = new frmKorisnickiNaloziDodajUredi(item as MoTechFull.Model.KorisnickiNalozi);
            frm.ShowDialog();
        }
    }
}
