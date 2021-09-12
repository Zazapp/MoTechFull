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

namespace MoTechFull.WinUI.Kantoni
{
    public partial class frmKantoniPregled : Form
    {
        APIService _service = new APIService("Kanton");
        public frmKantoniPregled()
        {
            InitializeComponent();
        }

        private async void frmKantoniPregled_Load(object sender, EventArgs e)
        {
            cmbOznaka.Items.Add("---");
            var list = await _service.Get<List<Model.Kantoni>>();

            foreach (var kanton in list) 
            {
                cmbOznaka.Items.Add(kanton.Oznaka);
            }
            cmbOznaka.SelectedItem= cmbOznaka.Items[0];
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            KantoniSearchObject searchObject = new KantoniSearchObject
            {
                Naziv = txtNaziv.Text,
                Oznaka=cmbOznaka.SelectedItem.ToString()
                
            };

            var list = await _service.Get<List<Model.Kantoni>>(searchObject);
            dgvKantoni.DataSource = list;
        }

        private void dgvKantoni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvKantoni.SelectedRows[0].DataBoundItem;
            frmKantoniDodajUredi frm = new frmKantoniDodajUredi(item as MoTechFull.Model.Kantoni);
            frm.ShowDialog();
        }
    }
}
