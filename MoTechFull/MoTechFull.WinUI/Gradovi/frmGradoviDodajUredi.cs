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

namespace MoTechFull.WinUI.Gradovi
{
    public partial class frmGradoviDodajUredi : Form
    {
        private readonly APIService _gradovi = new APIService("Grad");
        private readonly APIService _kantoni = new APIService("Kanton");

        public Model.Gradovi _grad;
        public frmGradoviDodajUredi(Model.Gradovi grad=null)
        {
            InitializeComponent();
            _grad = grad;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            int gId = 0;

            if (_grad == null)
            {
                if (int.TryParse(cmbKanton.SelectedValue.ToString(), out int gid))
                {
                    gId = gid;
                }


                if (txtNaziv.Text != "" && txtNaziv.Text.Length >= 3)
                {
                    GradoviInsertRequest novi = new GradoviInsertRequest
                    {
                        Naziv = txtNaziv.Text,
                        KantonId = gId
                    };

                    var grad = await _gradovi.Insert<Model.Gradovi>(novi);
                    frmUspjehDodajUredi uspjeh = new frmUspjehDodajUredi();
                    uspjeh.Show();
                }
                else 
                {
                    lblGrad.Show();
                    lblMinimum.Show();
                }
            }

            else
            {
                if (txtNaziv.Text != null && txtNaziv.Text.Length >= 3 && cmbKanton.SelectedValue!=null)
                {
                    if (int.TryParse(cmbKanton.SelectedValue.ToString(), out int gid))
                    {
                        gId = gid;
                        int id = _grad.GradId;
                        GradoviUpdateRequest novi = new GradoviUpdateRequest
                        {
                            Naziv = txtNaziv.Text,
                            KantonId = gId
                        };

                        var grad = await _gradovi.Update<Model.Gradovi>(id, novi);
                        frmUspjehDodajUredi uspjeh = new frmUspjehDodajUredi();
                        uspjeh.Show();
                    }                   
                }
                else
                {
                    lblGrad.Show();
                    lblMinimum.Show();
                }
            }
        }

        private async void frmGradoviDodajUredi_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        public async Task LoadData() 
        {
            await LoadKantoni();

            if (_grad != null) 
            {
                txtNaziv.Text = _grad.Naziv;
            }
        }
        public async Task LoadKantoni() 
        {
            var result = await _kantoni.Get<List<Model.Kantoni>>();
            cmbKanton.DisplayMember = "Naziv";
            cmbKanton.ValueMember = "KantonId";
            cmbKanton.DataSource = result;
            if (_grad != null)
                cmbKanton.SelectedItem = _grad.Kanton;

        }
    }
}
