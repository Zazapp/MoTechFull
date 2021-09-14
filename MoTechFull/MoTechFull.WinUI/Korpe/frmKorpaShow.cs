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
using MoTechFull.WinUI.Racun;

namespace MoTechFull.WinUI.Korpe
{
    public partial class frmKorpaShow : Form
    {

        APIService _korpe = new APIService("Korpa");
        APIService _korpeArtikli = new APIService("KorpeArtikli");
        APIService _artikli = new APIService("Artikal");


        double ukupno = 0;
        Model.Korpe _korpa;
        public frmKorpaShow(Model.Korpe korpa)
        {
            InitializeComponent();
            _korpa = korpa;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmKorpaShow_Load(object sender, EventArgs e)
        {

            KorpeArtikliSearchObject search = new KorpeArtikliSearchObject()
            {
                IncludeListArtikal = true,
                IncludeListKorpa = true,
                KorpaId = _korpa.KorpaId
            };
            var list = await _korpeArtikli.Get<List<Model.KorpeArtikli>>(search);

            //var listItema = list.Where(q => q.KorpaId == _korpa.KorpaId).ToList();
            

            dgvKorpa.DataSource = list;
            dgvKorpa.Columns["KorpaArtikliId"].Visible = false;
            dgvKorpa.Columns["KorpaId"].Visible = false;
            dgvKorpa.Columns["ArtikalId"].Visible = false;
            dgvKorpa.Columns["Artikal"].Visible = false;
            dgvKorpa.Columns["Korpa"].Visible = false;

            
            double jedna;

            foreach(var stavka in list) 
            {
                jedna = stavka.Kolicina * stavka.Artikal.Cijena;
                ukupno += jedna;
            }

            txtUkupno.Text = ukupno.ToString();

        }

        private  void btnRacun_Click(object sender, EventArgs e)
        {
            frmShipping frm = new frmShipping(_korpa as Model.Korpe,ukupno);
            frm.ShowDialog();

        }

        private async void dgvKorpa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Model.KorpeArtikli korpaArtikal =(Model.KorpeArtikli)dgvKorpa.SelectedRows[0].DataBoundItem;
            

            await _korpeArtikli.Update<Model.KorpeArtikli>(korpaArtikal.KorpaArtikliId,new KorpeArtikliUpdateRequest() { Kolicina = 0 });
        }
    }
}
