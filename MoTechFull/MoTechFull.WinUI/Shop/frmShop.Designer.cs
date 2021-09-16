
namespace MoTechFull.WinUI.Shop
{
    partial class frmShop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.cmbProizvodjac = new System.Windows.Forms.ComboBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvShop = new System.Windows.Forms.DataGridView();
            this.btnKorpa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRecommended = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecommended)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(25, 41);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(177, 20);
            this.txtNaziv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategorija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Proizvođač";
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(257, 40);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(177, 21);
            this.cmbKategorija.TabIndex = 4;
            // 
            // cmbProizvodjac
            // 
            this.cmbProizvodjac.FormattingEnabled = true;
            this.cmbProizvodjac.Location = new System.Drawing.Point(481, 41);
            this.cmbProizvodjac.Name = "cmbProizvodjac";
            this.cmbProizvodjac.Size = new System.Drawing.Size(177, 21);
            this.cmbProizvodjac.TabIndex = 5;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(694, 36);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(91, 28);
            this.btnPretraga.TabIndex = 6;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvShop);
            this.groupBox1.Location = new System.Drawing.Point(4, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 285);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shop";
            // 
            // dgvShop
            // 
            this.dgvShop.AllowUserToAddRows = false;
            this.dgvShop.AllowUserToDeleteRows = false;
            this.dgvShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShop.Location = new System.Drawing.Point(3, 16);
            this.dgvShop.Name = "dgvShop";
            this.dgvShop.ReadOnly = true;
            this.dgvShop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShop.Size = new System.Drawing.Size(778, 266);
            this.dgvShop.TabIndex = 0;
            this.dgvShop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShop_CellContentClick);
            // 
            // btnKorpa
            // 
            this.btnKorpa.Location = new System.Drawing.Point(714, 539);
            this.btnKorpa.Name = "btnKorpa";
            this.btnKorpa.Size = new System.Drawing.Size(79, 43);
            this.btnKorpa.TabIndex = 8;
            this.btnKorpa.Text = "Moja Korpa";
            this.btnKorpa.UseVisualStyleBackColor = true;
            this.btnKorpa.Click += new System.EventHandler(this.btnKorpa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvRecommended);
            this.groupBox2.Location = new System.Drawing.Point(7, 438);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 144);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FOR YOU";
            // 
            // dgvRecommended
            // 
            this.dgvRecommended.AllowUserToAddRows = false;
            this.dgvRecommended.AllowUserToDeleteRows = false;
            this.dgvRecommended.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRecommended.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecommended.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecommended.Location = new System.Drawing.Point(3, 16);
            this.dgvRecommended.Name = "dgvRecommended";
            this.dgvRecommended.ReadOnly = true;
            this.dgvRecommended.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecommended.Size = new System.Drawing.Size(662, 125);
            this.dgvRecommended.TabIndex = 0;
            this.dgvRecommended.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecommended_CellContentClick);
            // 
            // frmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 594);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnKorpa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.cmbProizvodjac);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmShop";
            this.Text = "MoTech Shop";
            this.Load += new System.EventHandler(this.frmShop_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecommended)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.ComboBox cmbProizvodjac;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvShop;
        private System.Windows.Forms.Button btnKorpa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvRecommended;
    }
}