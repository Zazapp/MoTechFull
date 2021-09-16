
namespace MoTechFull.WinUI.Gradovi
{
    partial class frmGradoviDodajUredi
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cmbKanton = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblGrad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv Grada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kanton";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(40, 44);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(258, 20);
            this.txtNaziv.TabIndex = 2;
            // 
            // cmbKanton
            // 
            this.cmbKanton.FormattingEnabled = true;
            this.cmbKanton.Location = new System.Drawing.Point(40, 87);
            this.cmbKanton.Name = "cmbKanton";
            this.cmbKanton.Size = new System.Drawing.Size(258, 21);
            this.cmbKanton.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(123, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrad.ForeColor = System.Drawing.Color.Red;
            this.lblGrad.Location = new System.Drawing.Point(182, 28);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(116, 13);
            this.lblGrad.TabIndex = 5;
            this.lblGrad.Text = "Naziv je obavezan.";
            this.lblGrad.Visible = false;
            // 
            // frmGradoviDodajUredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 175);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbKanton);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGradoviDodajUredi";
            this.Text = "Dodaj/Uredi Grad";
            this.Load += new System.EventHandler(this.frmGradoviDodajUredi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cmbKanton;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblGrad;
    }
}