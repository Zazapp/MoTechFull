
namespace MoTechFull.WinUI.Kantoni
{
    partial class frmKantoniDodajUredi
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtOznaka = new System.Windows.Forms.TextBox();
            this.lblKanton = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oznaka";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(88, 141);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(15, 49);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(242, 20);
            this.txtNaziv.TabIndex = 3;
            // 
            // txtOznaka
            // 
            this.txtOznaka.Location = new System.Drawing.Point(15, 93);
            this.txtOznaka.Name = "txtOznaka";
            this.txtOznaka.Size = new System.Drawing.Size(75, 20);
            this.txtOznaka.TabIndex = 4;
            // 
            // lblKanton
            // 
            this.lblKanton.AutoSize = true;
            this.lblKanton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKanton.ForeColor = System.Drawing.Color.Red;
            this.lblKanton.Location = new System.Drawing.Point(116, 93);
            this.lblKanton.Name = "lblKanton";
            this.lblKanton.Size = new System.Drawing.Size(141, 13);
            this.lblKanton.TabIndex = 5;
            this.lblKanton.Text = "Oba polja su obavezna!";
            this.lblKanton.Visible = false;
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimum.ForeColor = System.Drawing.Color.Red;
            this.lblMinimum.Location = new System.Drawing.Point(170, 33);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(87, 13);
            this.lblMinimum.TabIndex = 6;
            this.lblMinimum.Text = "(3+ karaktera)";
            this.lblMinimum.Visible = false;
            // 
            // frmKantoniDodajUredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 182);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.lblKanton);
            this.Controls.Add(this.txtOznaka);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKantoniDodajUredi";
            this.Text = "Dodaj/Uredi Kanton";
            this.Load += new System.EventHandler(this.frmKantoniDodajUredi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtOznaka;
        private System.Windows.Forms.Label lblKanton;
        private System.Windows.Forms.Label lblMinimum;
    }
}