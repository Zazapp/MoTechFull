
namespace MoTechFull.WinUI.Racun
{
    partial class frmRacun
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
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.btnOkay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRacun = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(58, 458);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(224, 20);
            this.txtDatum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ukupno:";
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(341, 458);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.ReadOnly = true;
            this.txtUkupno.Size = new System.Drawing.Size(116, 20);
            this.txtUkupno.TabIndex = 3;
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(564, 452);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(127, 31);
            this.btnOkay.TabIndex = 4;
            this.btnOkay.Text = "OK";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRacun);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 406);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Racun";
            // 
            // dgvRacun
            // 
            this.dgvRacun.AllowUserToAddRows = false;
            this.dgvRacun.AllowUserToDeleteRows = false;
            this.dgvRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRacun.Location = new System.Drawing.Point(3, 16);
            this.dgvRacun.Name = "dgvRacun";
            this.dgvRacun.ReadOnly = true;
            this.dgvRacun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacun.Size = new System.Drawing.Size(673, 387);
            this.dgvRacun.TabIndex = 0;
            // 
            // frmRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDatum);
            this.Name = "frmRacun";
            this.Text = "Racun";
            this.Load += new System.EventHandler(this.frmRacun_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRacun;
    }
}