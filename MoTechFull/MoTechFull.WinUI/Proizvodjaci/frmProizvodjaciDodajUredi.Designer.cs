
namespace MoTechFull.WinUI.Proizvodjaci
{
    partial class frmProizvodjaciDodajUredi
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
            this.lblProizvodjac = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime Proizvođača";
            // 
            // lblProizvodjac
            // 
            this.lblProizvodjac.AutoSize = true;
            this.lblProizvodjac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProizvodjac.ForeColor = System.Drawing.Color.Red;
            this.lblProizvodjac.Location = new System.Drawing.Point(53, 103);
            this.lblProizvodjac.Name = "lblProizvodjac";
            this.lblProizvodjac.Size = new System.Drawing.Size(182, 13);
            this.lblProizvodjac.TabIndex = 1;
            this.lblProizvodjac.Text = "Ime proizvođača je obavezno! ";
            this.lblProizvodjac.Visible = false;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(56, 70);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(162, 20);
            this.txtNaziv.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(76, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimum.ForeColor = System.Drawing.Color.Red;
            this.lblMinimum.Location = new System.Drawing.Point(90, 116);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(88, 13);
            this.lblMinimum.TabIndex = 4;
            this.lblMinimum.Text = "(3+ Karaktera)";
            this.lblMinimum.Visible = false;
            // 
            // frmProizvodjaciDodajUredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 182);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblProizvodjac);
            this.Controls.Add(this.label1);
            this.Name = "frmProizvodjaciDodajUredi";
            this.Text = "Dodaj/Uredi Proizvodjaca";
            this.Load += new System.EventHandler(this.frmProizvodjaciDodajUredi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMinimum;
    }
}