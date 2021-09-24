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

namespace MoTechFull.WinUI.KorisnickiNalozi
{
    public partial class frmKorisnickiNaloziDodajUredi : Form
    {

        APIService _service = new APIService("KorisnickiNalog");
        int tip;
        private MoTechFull.Model.KorisnickiNalozi _korisnik;
        public frmKorisnickiNaloziDodajUredi(MoTechFull.Model.KorisnickiNalozi korisnik=null)
        {
            InitializeComponent();
            tip = -1;
            _korisnik = korisnik;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(txtNaziv.Text!="" && txtNaziv.Text.Length >= 3 ) 
            {
            

            if (_korisnik == null)
            {
                if (txtLozinka1.Text != "" && txtLozinka1.Text == txtLozinka2.Text)
                {

                    KorisnickiNaloziInsertUpdateRequest novi = new KorisnickiNaloziInsertUpdateRequest
                    {
                        KorisnickoIme = txtNaziv.Text,
                        Lozinka = txtLozinka1.Text,
                        Tip = tip + 1
                    };

                    var korisnik = await _service.Insert<Model.KorisnickiNalozi>(novi);
                    frmUspjehDodajUredi uspjeh = new frmUspjehDodajUredi();
                    uspjeh.Show();
                }


                else lblMatching.Show();
            }

            else
            {
                if (txtLozinka1.Text != "" && txtLozinka1.Text == txtLozinka2.Text)
                {
                    int id = _korisnik.KorisnickiNalogId;
                    KorisnickiNaloziInsertUpdateRequest noviEdit = new KorisnickiNaloziInsertUpdateRequest
                    {
                        KorisnickoIme = txtNaziv.Text,
                        Lozinka = txtLozinka1.Text,
                        Tip = tip + 1
                    };

                    var korisnik = await _service.Update<Model.KorisnickiNalozi>(id, noviEdit);
                    frmUspjehDodajUredi uspjeh = new frmUspjehDodajUredi();
                    uspjeh.Show();
                }
                else lblMatching.Show();
            }
            }
            else { lblNaziv.Visible = true; }
        }

        private void frmKorisnickiNaloziDodajUredi_Load(object sender, EventArgs e)
        {
            string a1 = "Administrator";
            string b1 = "Prodavac";
            string c1 = "Klijent";
            cmbTip.Items.Add(a1);
            cmbTip.Items.Add(b1);
            cmbTip.Items.Add(c1);


            if (_korisnik != null)
            {
                txtNaziv.Text = _korisnik.KorisnickoIme;
                txtLozinka1.Text = _korisnik.Lozinka;
                txtLozinka2.Text = _korisnik.Lozinka;
            }

        }

        private void cmbTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            tip = cmbTip.SelectedIndex;
        }
    }
}
