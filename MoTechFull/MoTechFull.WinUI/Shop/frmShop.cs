﻿using MoTechFull.Model;
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
using MoTechFull.WinUI.Korpe;

namespace MoTechFull.WinUI.Shop
{
    public partial class frmShop : Form
    {

        APIService _artikli = new APIService("Artikal");
        APIService _kategorije = new APIService("Kategorija");
        APIService _proizvodjaci = new APIService("Proizvodjac");
        APIService _korpe = new APIService("Korpa");
        APIService _korisnici = new APIService("KorisnickiNalog");
        APIService _korpeArtikli = new APIService("KorpeArtikli");

        Model.Korpe _korpa;
        int firstItemId=0;
        public frmShop()
        {
            InitializeComponent();
            
        }

        private async void frmShop_Load(object sender, EventArgs e)
        {          

            int korisnikId;
            var sviKorisnici = await _korisnici.Get<List<Model.KorisnickiNalozi>>();
            korisnikId = sviKorisnici.Where(w => w.KorisnickoIme == APIService.Username && w.Lozinka == APIService.Password).Select(x => x.KorisnickiNalogId).FirstOrDefault();
            var list = await _korpe.Get<List<Model.Korpe>>(new KorpeSearchObject() {KorisnickiNalogId=korisnikId });
            if (!list.Any())
            {
                KorpeInsertRequest nova = new KorpeInsertRequest
                {
                    DatumDodavanja = DateTime.Now,
                    KorisnickiNalogId = korisnikId
                };

                var result=await _korpe.Insert<Model.Korpe>(nova);
                _korpa = result;
            }
            await LoadData();
        }

        public async Task LoadData() 
        {
            await LoadKategorije();
            await LoadProizvodjaci();
            await LoadRecommended();
        }

        public async Task LoadKategorije() 
        {
            var result = await _kategorije.Get<List<Model.Kategorije>>();
            result.Insert(0, new Model.Kategorije { Naziv = "---", KategorijaId = 0 });
            cmbKategorija.DisplayMember = "Naziv";
            cmbKategorija.ValueMember = "KategorijaId";
            cmbKategorija.DataSource = result;
        }

        private async Task LoadProizvodjaci()
        {
            var result = await _proizvodjaci.Get<List<Model.Proizvodjaci>>();
            result.Insert(0, new Model.Proizvodjaci { Naziv = "---", ProizvodjacId = 0 });
            cmbProizvodjac.DisplayMember = "Naziv";
            cmbProizvodjac.ValueMember = "ProizvodjacId";
            cmbProizvodjac.DataSource = result;
        }

        private async Task LoadRecommended() 
        {          
            if (firstItemId != 0) 
            {
                try 
                {
                    var result = await _artikli.Recommend<List<Model.Artikli>>(firstItemId);
                    //var result2 = await _artikli.Get<List<Model.Artikli>>(new ArtikliSearchObject()
                    //{
                    //    IncludeListKategorija = true,
                    //    IncludeListProizvodjac=true
                        
                    //});
                    dgvRecommended.DataSource = result;
                    dgvRecommended.Columns["Kategorija"].Visible = false;
                    dgvRecommended.Columns["Proizvodjac"].Visible = false;
                    dgvRecommended.Columns["KategorijaId"].Visible = false;
                    dgvRecommended.Columns["ProizvodjacId"].Visible = false;
                    dgvRecommended.Columns["KategorijaIdNaziv"].Visible = false;
                    dgvRecommended.Columns["ProizvodjacIdNaziv"].Visible = false;
                    //dgvRecommended.Columns["ArtikalId"].Visible = false;


                }
                catch { }

            }
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {

           

            ArtikliSearchObject searchRequest = new ArtikliSearchObject()
            {
                Naziv = txtNaziv.Text,
                IncludeListKategorija = true,
                IncludeListProizvodjac = true,
                KategorijaId=(int)cmbKategorija.SelectedValue,
                ProizvodjacId=(int)cmbProizvodjac.SelectedValue

            };

            var list = await _artikli.Get<List<Model.Artikli>>(searchRequest);
            dgvShop.DataSource = list;
            dgvShop.Columns["Kategorija"].Visible = false;
            dgvShop.Columns["Proizvodjac"].Visible = false;
            dgvShop.Columns["KategorijaId"].Visible = false;
            dgvShop.Columns["ProizvodjacId"].Visible = false;

            if (list.Any()) 
            {
                var item = list.First();
                firstItemId = item.ArtikalId;
            }

            await LoadRecommended();
        }

        private async void dgvShop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var list = await _korpe.Get<List<Model.Korpe>>();
            var sviKorisnici = await _korisnici.Get<List<Model.KorisnickiNalozi>>();
            int korisnikId = sviKorisnici.Where(w => w.KorisnickoIme == APIService.Username && w.Lozinka == APIService.Password).Select(x => x.KorisnickiNalogId).FirstOrDefault();
            _korpa = list.Where(w => w.KorisnickiNalogId == korisnikId).FirstOrDefault();

            var _artikal = dgvShop.SelectedRows[0].DataBoundItem;
            frmKorpaDodaj frm = new frmKorpaDodaj(_artikal as MoTechFull.Model.Artikli, _korpa as MoTechFull.Model.Korpe);
            frm.ShowDialog();
        }

        private async void btnKorpa_Click(object sender, EventArgs e)
        {
            var list = await _korpe.Get<List<Model.Korpe>>();
                int korisnikId;
                var sviKorisnici = await _korisnici.Get<List<Model.KorisnickiNalozi>>();
                korisnikId = sviKorisnici.Where(w => w.KorisnickoIme == APIService.Username && w.Lozinka == APIService.Password).Select(x => x.KorisnickiNalogId).FirstOrDefault();
            if (!list.Any()) 
            {
                KorpeInsertRequest nova = new KorpeInsertRequest
                {
                    DatumDodavanja = DateTime.Now,
                    KorisnickiNalogId = korisnikId
                };

                await _korpe.Insert<Model.Korpe>(nova);
            }
            _korpa= list.Where(w => w.KorisnickiNalogId == korisnikId).FirstOrDefault();

            frmKorpaShow frm = new frmKorpaShow(_korpa as MoTechFull.Model.Korpe);
            frm.ShowDialog();
        }

        private async void dgvRecommended_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var list = await _korpe.Get<List<Model.Korpe>>();
            var sviKorisnici = await _korisnici.Get<List<Model.KorisnickiNalozi>>();
            int korisnikId = sviKorisnici.Where(w => w.KorisnickoIme == APIService.Username && w.Lozinka == APIService.Password).Select(x => x.KorisnickiNalogId).FirstOrDefault();
            _korpa = list.Where(w => w.KorisnickiNalogId == korisnikId).FirstOrDefault();

            var _artikal = dgvRecommended.SelectedRows[0].DataBoundItem;
            frmKorpaDodaj frm = new frmKorpaDodaj(_artikal as MoTechFull.Model.Artikli, _korpa as MoTechFull.Model.Korpe);
            frm.ShowDialog();
        }
    }
}
