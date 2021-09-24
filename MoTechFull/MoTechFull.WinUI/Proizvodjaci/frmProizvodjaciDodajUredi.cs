using MoTechFull.Model.Requests;
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
                if (txtNaziv.Text != "" && txtNaziv.Text.Length >= 3)
                {
                    ProizvodjaciInsertUpdateRequest novi = new ProizvodjaciInsertUpdateRequest
                    {
                        Naziv = txtNaziv.Text
                    };

                    var proizvodjac = await _service.Insert<Model.Proizvodjaci>(novi);
                    frmUspjehDodajUredi uspjeh = new frmUspjehDodajUredi();
                    uspjeh.Show();
                }
                else
                {
                    lblProizvodjac.Show();
                    lblMinimum.Show();
                }

            }

            else
            {
                if (txtNaziv.Text != null && txtNaziv.Text.Length >= 3)
                {
                    int id = _proizvodjac.ProizvodjacId;
                    ProizvodjaciInsertUpdateRequest nova = new ProizvodjaciInsertUpdateRequest
                    {
                        Naziv = txtNaziv.Text
                    };

                    var proizvodjac = await _service.Update<Model.Proizvodjaci>(id, nova);
                    frmUspjehDodajUredi uspjeh = new frmUspjehDodajUredi();
                    uspjeh.Show();
                }
                else
                {
                    lblProizvodjac.Show();
                    lblMinimum.Show();
                }
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
