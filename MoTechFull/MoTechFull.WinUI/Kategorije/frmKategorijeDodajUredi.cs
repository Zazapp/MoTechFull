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

namespace MoTechFull.WinUI.Kategorije
{
    public partial class frmKategorijeDodajUredi : Form
    {
        APIService _service = new APIService("Kategorija");

        public Model.Kategorije _kategorija;
        public frmKategorijeDodajUredi(Model.Kategorije kategorija=null)
        {
            InitializeComponent();
            _kategorija = kategorija;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            if (_kategorija == null)
            {
                if (txtNaziv.Text != "")
                {
                    Model.Kategorije nova = new Model.Kategorije
                    {
                        Naziv = txtNaziv.Text,
                        Opis = rtxtOpis.Text

                    };

                    var kategorija = await _service.Insert<Model.Kategorije>(nova);
                    frmUspjehDodajUredi uspjeh = new frmUspjehDodajUredi();
                    uspjeh.Show();
                }
                else lblKategorija.Show();
            }

            else
            {
                if (txtNaziv.Text != null)
                {
                    int id = _kategorija.KategorijaId;
                    Model.Kategorije nova = new Model.Kategorije
                    {
                        Naziv = txtNaziv.Text,
                        Opis = rtxtOpis.Text

                    };

                    var kategorija = await _service.Update<Model.Kategorije>(id, nova);
                    frmUspjehDodajUredi uspjeh = new frmUspjehDodajUredi();
                    uspjeh.Show();
                }
                else lblKategorija.Show();
            }
        }

        private void frmKategorijeDodajUredi_Load(object sender, EventArgs e)
        {
            if (_kategorija != null)
            {
                txtNaziv.Text = _kategorija.Naziv;
                rtxtOpis.Text = _kategorija.Opis;
            }
        }
    }
}
