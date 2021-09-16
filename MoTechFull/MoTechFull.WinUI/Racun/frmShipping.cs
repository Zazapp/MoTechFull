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
    public partial class frmShipping : Form
    {

        APIService _gradovi = new APIService("Grad");
        APIService _racuni = new APIService("Racun");
        APIService _narudzbeStavke = new APIService("NarudzbaStavke");
        APIService _kupciNarudzbe = new APIService("KupacNarudzbe");
        APIService _korpeArtikli = new APIService("KorpeArtikli");
        APIService _korisnickiNalozi = new APIService("KorisnickiNalog");

        Model.Korpe _korpa;
        double _ukupno;
        public frmShipping(Model.Korpe korpa,double ukupno)
        {
            InitializeComponent();
            _korpa = korpa;
            _ukupno = ukupno;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmShipping_Load(object sender, EventArgs e)
        {
            await LoadGradovi();
        }

        public async Task LoadGradovi() 
        {
            var list = await _gradovi.Get<List<Model.Gradovi>>();
            cmbGrad.DisplayMember = "Naziv";
            cmbGrad.ValueMember = "GradId";
            cmbGrad.DataSource = list;
        }



        private async void btnCheckOut_Click(object sender, EventArgs e)
        {

            if(txtAdresa.Text!="" && cmbGrad.SelectedItem != null) 
            {
            
                KorpeArtikliSearchObject korpeArtikliRequest = new KorpeArtikliSearchObject
                {
                    IncludeListArtikal = true,
                    IncludeListKorpa = true,
                    KorpaId = _korpa.KorpaId
                };

                var korpaArtikli = await _korpeArtikli.Get<List<Model.KorpeArtikli>>(korpeArtikliRequest);
                int korisnikId = _korpa.KorisnickiNalogId;

                int gradID = (int)cmbGrad.SelectedValue;
                string adresa = txtAdresa.Text;

                RacuniInsertRequest novi = new RacuniInsertRequest
                {
                    DatumIzdavanja = DateTime.Now,
                    Iznos = _ukupno

                };

                var result = await _racuni.Insert<Model.Racuni>(novi);


                foreach (var kartikal in korpaArtikli)
                {
                    KupciNarudzbeInsertRequest knir = new KupciNarudzbeInsertRequest
                    {
                        Datum = DateTime.Now,
                        IsIsporucena = false,
                        KorisnickiNalogId = korisnikId,
                        AdresaDostave = adresa,
                        GradId = gradID
                    };

                    var knResult = await _kupciNarudzbe.Insert<Model.KupciNarudzbe>(knir);

                    int racunId = result.RacunId;

                    NarudzbeStavkeInsertRequest nsir = new NarudzbeStavkeInsertRequest
                    {
                        RacunId = racunId,
                        Kolicina = kartikal.Kolicina,
                        ArtikalId = kartikal.ArtikalId,
                        Popust = 0,
                        UnitCijena = kartikal.Artikal.Cijena,
                        KupacNarudzbeId = knResult.KupacNarudzbeId
                    };

                    var nsResult = await _narudzbeStavke.Insert<Model.NarudzbeStavke>(nsir);

                }

                frmRacun frm = new frmRacun(result as Model.Racuni,_ukupno,_korpa.KorpaId);
                frm.ShowDialog();
            }
            else 
            {
                lblAdresa.Visible = true;
                lblGrad.Visible = true;
            }
        }
    }
}
