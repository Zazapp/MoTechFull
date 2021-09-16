
namespace MoTechFull.WinUI.Kategorije
{
    partial class frmKategorijeDodajUredi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtOpis = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime Kategorije";
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.ForeColor = System.Drawing.Color.Red;
            this.lblKategorija.Location = new System.Drawing.Point(221, 51);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(137, 13);
            this.lblKategorija.TabIndex = 1;
            this.lblKategorija.Text = "Ime kategorije je obavezno!";
            this.lblKategorija.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis";
            // 
            // rtxtOpis
            // 
            this.rtxtOpis.Location = new System.Drawing.Point(19, 117);
            this.rtxtOpis.Name = "rtxtOpis";
            this.rtxtOpis.Size = new System.Drawing.Size(178, 96);
            this.rtxtOpis.TabIndex = 3;
            this.rtxtOpis.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(247, 246);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 32);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(19, 48);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(178, 20);
            this.txtNaziv.TabIndex = 5;
            // 
            // frmKategorijeDodajUredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 293);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtxtOpis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.label1);
            this.Name = "frmKategorijeDodajUredi";
            this.Text = "Dodaj/Uredi Kategoriju";
            this.Load += new System.EventHandler(this.frmKategorijeDodajUredi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtOpis;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNaziv;
    }
}