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

namespace MoTechFull.WinUI.Proizvodjaci
{
    public partial class frmProizvodjaciPrikazi : Form
    {
        APIService _service = new APIService("Proizvodjac");
        public frmProizvodjaciPrikazi()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            ProizvodjaciSearchObject searchObject = new ProizvodjaciSearchObject
            {
                Naziv = txtNaziv.Text
            };

            var list = await _service.Get<List<Model.Proizvodjaci>>(searchObject);
            dgvProizvodjaci.DataSource = list;
        }

        private void dgvProizvodjaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvProizvodjaci.SelectedRows[0].DataBoundItem;
            frmProizvodjaciDodajUredi frm = new frmProizvodjaciDodajUredi(item as MoTechFull.Model.Proizvodjaci);
            frm.ShowDialog();
        }
    }
}
