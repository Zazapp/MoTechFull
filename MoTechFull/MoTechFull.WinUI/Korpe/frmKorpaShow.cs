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
            var list = await _korpeArtikli.Get<List<Model.KorpeArtikli>>();

            var listItema = list.Where(q => q.KorpaId == _korpa.KorpaId).ToList();

            dgvKorpa.DataSource = listItema;
            dgvKorpa.Columns["KorpaArtikliId"].Visible = false;
            dgvKorpa.Columns["KorpaId"].Visible = false;
            dgvKorpa.Columns["ArtikalId"].Visible = false;

            double ukupno=0;
            double jedna;

            foreach(var stavka in listItema) 
            {
                jedna = stavka.Kolicina * stavka.Cijena;
                ukupno += jedna;
            }

            txtUkupno.Text = ukupno.ToString();

        }
    }
}
