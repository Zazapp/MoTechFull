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

namespace MoTechFull.WinUI.Gradovi
{
    public partial class frmGradoviPregled : Form
    {

        private readonly APIService _gradovi = new APIService("Grad");
        private readonly APIService _kantoni = new APIService("Kanton");

        public frmGradoviPregled()
        {
            InitializeComponent();
        }

        private async void frmGradoviPregled_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        public async Task LoadData() 
        {
            var list = await _kantoni.Get<List<Model.Kantoni>>();
            cmbKanton.Items.Add("---");

            foreach(var kanton in list) 
            {
                cmbKanton.Items.Add(kanton.Naziv);
            }
            cmbKanton.SelectedItem = cmbKanton.Items[0];
        }

        private async void btnPregled_Click(object sender, EventArgs e)
        {

            GradoviSearchObject searchObject = new GradoviSearchObject
            {
                Naziv = txtNaziv.Text,
                KantonNaziv = cmbKanton.SelectedItem.ToString()

            };

            var list = await _gradovi.Get<List<Model.Gradovi>>(searchObject);
            dgvGradovi.DataSource = list;
            dgvGradovi.Columns["Kanton"].Visible = false;
        }

        private void dgvGradovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvGradovi.SelectedRows[0].DataBoundItem;
            frmGradoviDodajUredi frm = new frmGradoviDodajUredi(item as MoTechFull.Model.Gradovi);
            frm.ShowDialog();
        }
    }
}
