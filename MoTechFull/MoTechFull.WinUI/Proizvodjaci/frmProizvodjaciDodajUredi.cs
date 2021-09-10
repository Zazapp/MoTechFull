using MoTechFull.WinUI.Helper;
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
    public partial class frmProizvodjaciDodajUredi : Form
    {

        APIService _service = new APIService("Proizvodjac");

        private MoTechFull.Model.Proizvodjaci _proizvodjac;
        public frmProizvodjaciDodajUredi(Model.Proizvodjaci proizvodjac = null)
        {
            InitializeComponent();
            _proizvodjac = proizvodjac;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_proizvodjac == null)
            {
                if (txtNaziv.Text != "")
                {
                    Model.Proizvodjaci novi = new Model.Proizvodjaci
                    {
                        Naziv = txtNaziv.Text
                    };

                    var proizvodjac = await _service.Insert<Model.Proizvodjaci>(novi);
                    frmUspjehDodajUredi uspjeh = new frmUspjehDodajUredi();
                    uspjeh.Show();
                }
                else lblProizvodjac.Show();
            }

            else
            {
                if (txtNaziv.Text != null)
                {
                    int id = _proizvodjac.ProizvodjacId;
                    Model.Proizvodjaci nova = new Model.Proizvodjaci
                    {
                        Naziv = txtNaziv.Text
                    };

                    var proizvodjac = await _service.Update<Model.Proizvodjaci>(id, nova);
                    frmUspjehDodajUredi uspjeh = new frmUspjehDodajUredi();
                    uspjeh.Show();
                }
                else lblProizvodjac.Show();
            }
        }

        private void frmProizvodjaciDodajUredi_Load(object sender, EventArgs e)
        {
            if (_proizvodjac != null)
            {
                txtNaziv.Text = _proizvodjac.Naziv;
            }
        }
    }
}
