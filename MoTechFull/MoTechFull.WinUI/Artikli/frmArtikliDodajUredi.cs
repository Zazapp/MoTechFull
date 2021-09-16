using MoTechFull.Model.Requests;
using MoTechFull.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoTechFull.WinUI.Artikli
{
    public partial class frmArtikliDodajUredi : Form
    {

        APIService _artikli = new APIService("Artikal");
        APIService _kategorije = new APIService("Kategorija");
        APIService _proizvodjaci = new APIService("Proizvodjac");

        Image slikaR = null;

        public Model.Artikli _artikal;
        public frmArtikliDodajUredi(Model.Artikli artikal=null)
        {
            InitializeComponent();
            _artikal = artikal;
        }

        private async void frmArtikliDodajUredi_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            await LoadKategorije();
            await LoadProizvodjaci();

            if (_artikal != null)
            {
                txtNaziv.Text = _artikal.Naziv;
                txtCijena.Text= _artikal.Cijena.ToString();
                rtxtOpis.Text = _artikal.Opis;
                chbDostupan.Checked = _artikal.Dostupan;
            }
        }

        private async Task LoadKategorije()
        {
            var result = await _kategorije.Get<List<Model.Kategorije>>();
            cmbKategorije.DisplayMember = "Naziv";
            cmbKategorije.ValueMember = "KategorijaId";
            cmbKategorije.DataSource = result;
            if (_artikal != null)
                cmbKategorije.SelectedItem = _artikal.Kategorija;

        }

        private async Task LoadProizvodjaci()
        {
            var result = await _proizvodjaci.Get<List<Model.Proizvodjaci>>();
            cmbProizvodjaci.DisplayMember = "Naziv";
            cmbProizvodjaci.ValueMember = "ProizvodjacId";
            cmbProizvodjaci.DataSource = result;
            if (_artikal != null)
                cmbProizvodjaci.SelectedItem = _artikal.Proizvodjac;
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            var result = ofdSlika.ShowDialog();

            if (result == DialogResult.OK)
            { 
                var fileName = ofdSlika.FileName;
                var file = File.ReadAllBytes(fileName);
                slikaR = Image.FromFile(fileName);
                txtSlika.Text = fileName;
                pcbSlika.Image = Image.FromFile(fileName);
            }

        }
            
        private async void btnSave_Click(object sender, EventArgs e)
        {

            if (txtNaziv.Text != "" && txtNaziv.Text.Length > 3 && txtCijena.Text!="" && txtSlika.Text!="")
            {


                    int katId = 0;
                    int proId = 0;
                    var ms = new MemoryStream();
                    slikaR.Save(ms, slikaR.RawFormat);
                    byte[] slikapre = ms.ToArray();

                    if (double.TryParse(txtCijena.Text.ToString(), out double _cijena))
                    {
                        if (int.TryParse(cmbKategorije.SelectedValue.ToString(), out int kid))
                        {
                            katId = kid;
                        }
                        if (int.TryParse(cmbProizvodjaci.SelectedValue.ToString(), out int pid))
                        {
                            proId = pid;
                        }

                        if (_artikal == null)
                        {
                            ArtikliInsertRequest novi = new ArtikliInsertRequest
                            {
                                Cijena = _cijena,
                                Dostupan = chbDostupan.Checked,
                                Image = slikapre,
                                Naziv = txtNaziv.Text.ToString(),
                                Opis = rtxtOpis.Text.ToString(),
                                KategorijaId = katId,
                                ProizvodjacId = proId

                            };

                            var k = await _artikli.Insert<Model.Artikli>(novi);
                            frmUspjehDodajUredi uspjeh = new frmUspjehDodajUredi();
                            uspjeh.Show();
                        }
                        else
                        {
                            int id = _artikal.ArtikalId;
                            ArtikliUpdateRequest noviE = new ArtikliUpdateRequest
                            {
                                Cijena = _cijena,
                                Dostupan = chbDostupan.Checked,
                                Image = slikapre,
                                Naziv = txtNaziv.Text.ToString(),
                                Opis = rtxtOpis.Text.ToString(),
                                KategorijaId = katId,
                                ProizvodjacId = proId,
                                Id = id


                            };
                            var k = await _artikli.Update<Model.Artikli>(id, noviE);
                            frmUspjehDodajUredi uspjeh = new frmUspjehDodajUredi();
                            uspjeh.Show();
                        }
                    }
                    
            }
            else
            {
                lblObavezna.Visible = true;
                lblCijena.Visible = true;
                lblSlika.Visible = true;

            }
        }
    }
}
