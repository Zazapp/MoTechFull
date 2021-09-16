
using System;

namespace MoTechFull.WinUI.Kantoni
{
    partial class frmKantoniPregled
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKantoni = new System.Windows.Forms.DataGridView();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cmbOznaka = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKantoni)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 27);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oznaka";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(275, 91);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(99, 24);
            this.btnPretraga.TabIndex = 2;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKantoni);
            this.groupBox1.Location = new System.Drawing.Point(2, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 191);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kantoni";
            // 
            // dgvKantoni
            // 
            this.dgvKantoni.AllowUserToAddRows = false;
            this.dgvKantoni.AllowUserToDeleteRows = false;
            this.dgvKantoni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKantoni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKantoni.Location = new System.Drawing.Point(3, 16);
            this.dgvKantoni.Name = "dgvKantoni";
            this.dgvKantoni.ReadOnly = true;
            this.dgvKantoni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKantoni.Size = new System.Drawing.Size(394, 172);
            this.dgvKantoni.TabIndex = 0;
            this.dgvKantoni.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKantoni_CellContentClick);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(15, 43);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(217, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // cmbOznaka
            // 
            this.cmbOznaka.FormattingEnabled = true;
            this.cmbOznaka.Location = new System.Drawing.Point(12, 91);
            this.cmbOznaka.Name = "cmbOznaka";
            this.cmbOznaka.Size = new System.Drawing.Size(121, 21);
            this.cmbOznaka.TabIndex = 5;
            // 
            // frmKantoniPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.cmbOznaka);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNaziv);
            this.Name = "frmKantoniPregled";
            this.Text = "Kantoni";
            this.Load += new System.EventHandler(this.frmKantoniPregled_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKantoni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKantoni;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cmbOznaka;
    }
}