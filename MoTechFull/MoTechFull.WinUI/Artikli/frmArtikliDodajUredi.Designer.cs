
namespace MoTechFull.WinUI.Artikli
{
    partial class frmArtikliDodajUredi
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUcitajSliku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKategorije = new System.Windows.Forms.ComboBox();
            this.cmbProizvodjaci = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxtOpis = new System.Windows.Forms.RichTextBox();
            this.pcbSlika = new System.Windows.Forms.PictureBox();
            this.ofdSlika = new System.Windows.Forms.OpenFileDialog();
            this.lblObavezna = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.lblSlika = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(12, 67);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(172, 20);
            this.txtNaziv.TabIndex = 0;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(12, 199);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(171, 20);
            this.txtCijena.TabIndex = 1;
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(262, 199);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(172, 20);
            this.txtSlika.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(176, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUcitajSliku
            // 
            this.btnUcitajSliku.Location = new System.Drawing.Point(453, 199);
            this.btnUcitajSliku.Name = "btnUcitajSliku";
            this.btnUcitajSliku.Size = new System.Drawing.Size(33, 23);
            this.btnUcitajSliku.TabIndex = 4;
            this.btnUcitajSliku.Text = "...";
            this.btnUcitajSliku.UseVisualStyleBackColor = true;
            this.btnUcitajSliku.Click += new System.EventHandler(this.btnUcitajSliku_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cijena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Slika";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kategorija";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Proizvodjac";
            // 
            // cmbKategorije
            // 
            this.cmbKategorije.FormattingEnabled = true;
            this.cmbKategorije.Location = new System.Drawing.Point(13, 131);
            this.cmbKategorije.Name = "cmbKategorije";
            this.cmbKategorije.Size = new System.Drawing.Size(171, 21);
            this.cmbKategorije.TabIndex = 10;
            // 
            // cmbProizvodjaci
            // 
            this.cmbProizvodjaci.FormattingEnabled = true;
            this.cmbProizvodjaci.Location = new System.Drawing.Point(265, 131);
            this.cmbProizvodjaci.Name = "cmbProizvodjaci";
            this.cmbProizvodjaci.Size = new System.Drawing.Size(169, 21);
            this.cmbProizvodjaci.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Opis";
            // 
            // rtxtOpis
            // 
            this.rtxtOpis.Location = new System.Drawing.Point(13, 264);
            this.rtxtOpis.Name = "rtxtOpis";
            this.rtxtOpis.Size = new System.Drawing.Size(171, 95);
            this.rtxtOpis.TabIndex = 14;
            this.rtxtOpis.Text = "";
            // 
            // pcbSlika
            // 
            this.pcbSlika.Location = new System.Drawing.Point(262, 264);
            this.pcbSlika.Name = "pcbSlika";
            this.pcbSlika.Size = new System.Drawing.Size(172, 95);
            this.pcbSlika.TabIndex = 15;
            this.pcbSlika.TabStop = false;
            // 
            // ofdSlika
            // 
            this.ofdSlika.FileName = "ofdSlika";
            // 
            // lblObavezna
            // 
            this.lblObavezna.AutoSize = true;
            this.lblObavezna.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObavezna.ForeColor = System.Drawing.Color.Red;
            this.lblObavezna.Location = new System.Drawing.Point(166, 40);
            this.lblObavezna.Name = "lblObavezna";
            this.lblObavezna.Size = new System.Drawing.Size(18, 24);
            this.lblObavezna.TabIndex = 16;
            this.lblObavezna.Text = "*";
            this.lblObavezna.Visible = false;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCijena.ForeColor = System.Drawing.Color.Red;
            this.lblCijena.Location = new System.Drawing.Point(165, 175);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(18, 24);
            this.lblCijena.TabIndex = 17;
            this.lblCijena.Text = "*";
            this.lblCijena.Visible = false;
            // 
            // lblSlika
            // 
            this.lblSlika.AutoSize = true;
            this.lblSlika.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlika.ForeColor = System.Drawing.Color.Red;
            this.lblSlika.Location = new System.Drawing.Point(416, 175);
            this.lblSlika.Name = "lblSlika";
            this.lblSlika.Size = new System.Drawing.Size(18, 24);
            this.lblSlika.TabIndex = 18;
            this.lblSlika.Text = "*";
            this.lblSlika.Visible = false;
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimum.ForeColor = System.Drawing.Color.Red;
            this.lblMinimum.Location = new System.Drawing.Point(84, 51);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(87, 13);
            this.lblMinimum.TabIndex = 19;
            this.lblMinimum.Text = "(3+ karaktera)";
            this.lblMinimum.Visible = false;
            // 
            // frmArtikliDodajUredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 451);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.lblSlika);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblObavezna);
            this.Controls.Add(this.pcbSlika);
            this.Controls.Add(this.rtxtOpis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbProizvodjaci);
            this.Controls.Add(this.cmbKategorije);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUcitajSliku);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmArtikliDodajUredi";
            this.Text = "Dodaj/Uredi Artikal";
            this.Load += new System.EventHandler(this.frmArtikliDodajUredi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUcitajSliku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKategorije;
        private System.Windows.Forms.ComboBox cmbProizvodjaci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxtOpis;
        private System.Windows.Forms.PictureBox pcbSlika;
        private System.Windows.Forms.OpenFileDialog ofdSlika;
        private System.Windows.Forms.Label lblObavezna;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label lblSlika;
        private System.Windows.Forms.Label lblMinimum;
    }
}