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

namespace MoTechFull.WinUI.Korpe
{
    public partial class frmKorpaDodaj : Form
    {
        APIService _korpeArtikli = new APIService("KorpeArtikli");

        Model.Artikli _artikal;
        Model.Korpe _korpa;
        float ukupno;
        int kolicina=0;
        bool postoji;
        int korpaArtikalId;
        public frmKorpaDodaj(Model.Artikli artikal,Model.Korpe korpa)
        {
            InitializeComponent();
            _artikal = artikal;
            _korpa = korpa;
        }

        private async void frmKorpaDodaj_Load(object sender, EventArgs e)
        {
            txtNaziv.Text = _artikal.Naziv;
            txtCijena.Text = _artikal.Cijena.ToString();

            var list = await _korpeArtikli.Get<List<Model.KorpeArtikli>>();
            try 
            {
                kolicina = list.Where(w => w.KorpaId == _korpa.KorpaId && w.ArtikalId == _artikal.ArtikalId).Select(x => x.Kolicina).FirstOrDefault();
                korpaArtikalId= list.Where(w => w.KorpaId == _korpa.KorpaId && w.ArtikalId == _artikal.ArtikalId).Select(x => x.KorpaArtikliId).FirstOrDefault();
                if(korpaArtikalId==0 || kolicina == 0)
                { postoji = false; }
                else postoji = true;
            }
            catch 
            {
                postoji = false;
            }
            txtKolicina.Text = kolicina.ToString();
            ukupno = (float)_artikal.Cijena*kolicina;
            txtUkupno.Text = ukupno.ToString();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (kolicina == 99) 
            {
                return;
            }
            kolicina += 1;
            ukupno = (float)_artikal.Cijena * kolicina;
            txtKolicina.Text = kolicina.ToString();
            txtUkupno.Text = ukupno.ToString();
        }

        private void btnOduzmi_Click(object sender, EventArgs e)
        {
            if (kolicina == 0) 
            {
                return;
            }
            kolicina -= 1;
            ukupno = (float)_artikal.Cijena * kolicina;
            txtKolicina.Text = kolicina.ToString();
            txtUkupno.Text = ukupno.ToString();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
           
            if (postoji) 
            {
                KorpeArtikliUpdateRequest request = new KorpeArtikliUpdateRequest
                {
                    Kolicina = kolicina
                };

                await _korpeArtikli.Update<Model.KorpeArtikli>(korpaArtikalId, request);
                this.Close();
            }

            if (!postoji) 
            {
                KorpeArtikliInsertRequest request = new KorpeArtikliInsertRequest
                {
                    ArtikalId = _artikal.ArtikalId,
                    KorpaId = _korpa.KorpaId,
                    Kolicina = kolicina,
                    Cijena=_artikal.Cijena
                };

                await _korpeArtikli.Insert<Model.KorpeArtikli>(request);
                this.Close();
            }
        }
    }
}
