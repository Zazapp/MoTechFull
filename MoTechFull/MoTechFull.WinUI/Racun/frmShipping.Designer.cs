
namespace MoTechFull.WinUI.Racun
{
    partial class frmShipping
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
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.lblGrad = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(26, 90);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(173, 20);
            this.txtAdresa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grad";
            // 
            // cmbGrad
            // 
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(26, 38);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(173, 21);
            this.cmbGrad.TabIndex = 3;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(217, 143);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(78, 28);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(13, 143);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 28);
            this.btnNazad.TabIndex = 5;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrad.ForeColor = System.Drawing.Color.Red;
            this.lblGrad.Location = new System.Drawing.Point(206, 38);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(18, 24);
            this.lblGrad.TabIndex = 6;
            this.lblGrad.Text = "*";
            this.lblGrad.Visible = false;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.ForeColor = System.Drawing.Color.Red;
            this.lblAdresa.Location = new System.Drawing.Point(205, 93);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(18, 24);
            this.lblAdresa.TabIndex = 7;
            this.lblAdresa.Text = "*";
            this.lblAdresa.Visible = false;
            // 
            // frmShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 183);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.cmbGrad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdresa);
            this.Name = "frmShipping";
            this.Text = "Dostava";
            this.Load += new System.EventHandler(this.frmShipping_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrad;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.Label lblAdresa;
    }
}