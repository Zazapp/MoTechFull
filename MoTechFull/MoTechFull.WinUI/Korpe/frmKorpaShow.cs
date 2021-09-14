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

namespace MoTechFull.WinUI.Korpe
{
    public partial class frmKorpaShow : Form
    {

        APIService _korpe = new APIService("Korpa");
        APIService _korpeArtikli = new APIService("KorpeArtikli");
        APIService _artikli = new APIService("Artikal");

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

            double ukupno=0;
            double jedna;

            foreach(var stavka in list) 
            {
                jedna = stavka.Kolicina * stavka.Artikal.Cijena;
                ukupno += jedna;
            }

            txtUkupno.Text = ukupno.ToString();

        }
    }
}
