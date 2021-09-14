using MoTechFull.Model;
using MoTechFull.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoTechFull.WinUI.Racun
{
    public partial class frmRacun : Form
    {

        APIService _narudzbeStavke = new APIService("NarudzbaStavke");
        APIService _korpeArtikli = new APIService("KorpeArtikli");

        Model.Racuni _racun;
        double _ukupno;
        int _korpaId;
        public frmRacun(Model.Racuni racun,double ukupno,int korpaId)
        {
            InitializeComponent();
            _racun = racun;
            _ukupno = ukupno;
            _korpaId = korpaId;
        }

        private async void frmRacun_Load(object sender, EventArgs e)
        {

            txtDatum.Text = _racun.DatumIzdavanja.ToString();
            txtUkupno.Text = _ukupno.ToString();
            await LoadRacun();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public async Task LoadRacun() 
        {
            NarudzbeStavkeSearchObject nsRequest = new NarudzbeStavkeSearchObject
            {
                IncludeListArtikal = true,
                IncludeListKupacNarudzbe = true,
                IncludeListRacun = true,
                RacunId = _racun.RacunId
            };

            var listStavke = await _narudzbeStavke.Get<List<Model.NarudzbeStavke>>(nsRequest);
            dgvRacun.DataSource = listStavke;
            dgvRacun.Columns["NarudzbaStavkeId"].Visible = false;
            dgvRacun.Columns["KupacNarudzbeId"].Visible = false;
            dgvRacun.Columns["ArtikalId"].Visible = false;
            dgvRacun.Columns["Artikal"].Visible = false;
            dgvRacun.Columns["Racun"].Visible = false;

            var listaArtikala = await _korpeArtikli.Get<List<Model.KorpeArtikli>>(new KorpeArtikliSearchObject() { KorpaId = _korpaId});

            foreach(var art in listaArtikala) 
            {
                await _korpeArtikli.Update<Model.KorpeArtikli>(art.KorpaArtikliId, new KorpeArtikliUpdateRequest() { Kolicina = 0 });
            }
        }
    }
}
