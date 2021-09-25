using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoTechFull.WinUI.Login
{
    public partial class frmLogin : Form
    {

        private readonly APIService _api = new APIService("Artikal");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;

            try
            {
                var result = await _api.Get<List<Model.KorisnickiNalozi>>();

                DialogResult = DialogResult.OK;
                //frmPocetna frm = new frmPocetna();
                //frm.Show();
            }
            catch
            {
                MessageBox.Show("Pogrešan username ili password");
            }
        }
    }
}
