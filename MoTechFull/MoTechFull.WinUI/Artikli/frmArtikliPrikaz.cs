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

namespace MoTechFull.WinUI
{
    public partial class frmPrikazArtikala : Form
    {

        APIService _serviceArtikli = new APIService("Artikal");
        public frmPrikazArtikala()
        {
            InitializeComponent();
        }

        private async void btnPretraga_Click_1(object sender, EventArgs e)
        {
            ArtikliSearchObject searchRequest = new ArtikliSearchObject()
            {
                Naziv = txtNaziv.Text,
                IncludeListKategorija = true,
                IncludeListProizvodjac = true
            };

            var list = await _serviceArtikli.Get<List<Model.Artikli>>(searchRequest);
            dgvArtikli.DataSource = list;
            dgvArtikli.Columns["Kategorija"].Visible = false;
            dgvArtikli.Columns["Proizvodjac"].Visible = false;
            dgvArtikli.Columns["KategorijaId"].Visible = false;
            dgvArtikli.Columns["ProizvodjacId"].Visible = false;
        }
    }
}
