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

namespace MoTechFull.WinUI.Kategorije
{
    public partial class frmKategorijePrikazi : Form
    {
        APIService _service = new APIService("Kategorija");
        public frmKategorijePrikazi()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvKategorije.SelectedRows[0].DataBoundItem;
            frmKategorijeDodajUredi frm = new frmKategorijeDodajUredi(item as MoTechFull.Model.Kategorije);
            frm.ShowDialog();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            KategorijeSearchObject searchObject = new KategorijeSearchObject
            {
                Naziv = txtNaziv.Text
            };

            var list = await _service.Get<List<Model.Kategorije>>(searchObject);
            dgvKategorije.DataSource = list;
            dgvKategorije.Columns["Image"].Visible = false;
        }
    }
}
