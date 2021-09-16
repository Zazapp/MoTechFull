
namespace MoTechFull.WinUI.Proizvodjaci
{
    partial class frmProizvodjaciPrikazi
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProizvodjaci = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodjaci)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime Proizvođača";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(13, 49);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(275, 45);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(89, 23);
            this.btnPretraga.TabIndex = 2;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProizvodjaci);
            this.groupBox1.Location = new System.Drawing.Point(4, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 232);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proizvođači";
            // 
            // dgvProizvodjaci
            // 
            this.dgvProizvodjaci.AllowUserToAddRows = false;
            this.dgvProizvodjaci.AllowUserToDeleteRows = false;
            this.dgvProizvodjaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodjaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProizvodjaci.Location = new System.Drawing.Point(3, 16);
            this.dgvProizvodjaci.Name = "dgvProizvodjaci";
            this.dgvProizvodjaci.ReadOnly = true;
            this.dgvProizvodjaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodjaci.Size = new System.Drawing.Size(395, 213);
            this.dgvProizvodjaci.TabIndex = 0;
            this.dgvProizvodjaci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProizvodjaci_CellContentClick);
            // 
            // frmProizvodjaciPrikazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "frmProizvodjaciPrikazi";
            this.Text = "Proizvodjaci";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodjaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProizvodjaci;
    }
}