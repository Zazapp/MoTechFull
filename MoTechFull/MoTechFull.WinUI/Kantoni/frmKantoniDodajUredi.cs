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

namespace MoTechFull.WinUI.Kantoni
{
    public partial class frmKantoniDodajUredi : Form
    {

        APIService _service = new APIService("Kanton");
        public Model.Kantoni _kanton;

        public frmKantoniDodajUredi(Model.Kantoni kanton=null)
        {
            InitializeComponent();
            _kanton = kanton;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_kanton == null)
            {
                if (txtNaziv.Text != "" && txtNaziv.Text.Length >= 3 && txtOznaka.Text != "")
                {
                    KantoniInsertUpdateRequest novi = new KantoniInsertUpdateRequest
                    {
                        Naziv = txtNaziv.Text,
                        Oznaka = txtOznaka.Text

                    };

                    var kanton = await _service.Insert<Model.Kantoni>(novi);
                    frmUspjehDodajUredi uspjeh = new frmUspjehDodajUredi();
                    uspjeh.Show();
                }
                else 
                {
                    lblKanton.Show();
                    lblMinimum.Show();
                } 
            }

            else
            {
                if (txtNaziv.Text != null && txtNaziv.Text.Length >= 3 && txtOznaka!=null)
                {
                    int id = _kanton.KantonId;
                    KantoniInsertUpdateRequest novi = new KantoniInsertUpdateRequest
                    {
                        Naziv = txtNaziv.Text,
                        Oznaka = txtOznaka.Text

                    };

                    var kanton = await _service.Update<Model.Kantoni>(id, novi);
                    frmUspjehDodajUredi uspjeh = new frmUspjehDodajUredi();
                    uspjeh.Show();
                }
                else
                {
                    lblKanton.Show();
                    lblMinimum.Show();
                }
            }

        }

        private void frmKantoniDodajUredi_Load(object sender, EventArgs e)
        {
            if (_kanton != null)
            {
                txtNaziv.Text = _kanton.Naziv;
                txtOznaka.Text = _kanton.Oznaka;
            }
        }
    }
}
