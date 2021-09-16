
namespace MoTechFull.WinUI.Kategorije
{
    partial class frmKategorijePrikazi
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
            this.dgvKategorije = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime Kategorije";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(13, 60);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(150, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(253, 56);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(99, 23);
            this.btnPretraga.TabIndex = 2;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKategorije);
            this.groupBox1.Location = new System.Drawing.Point(4, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 209);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategorije";
            // 
            // dgvKategorije
            // 
            this.dgvKategorije.AllowUserToAddRows = false;
            this.dgvKategorije.AllowUserToDeleteRows = false;
            this.dgvKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategorije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKategorije.Location = new System.Drawing.Point(3, 16);
            this.dgvKategorije.Name = "dgvKategorije";
            this.dgvKategorije.ReadOnly = true;
            this.dgvKategorije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKategorije.Size = new System.Drawing.Size(372, 190);
            this.dgvKategorije.TabIndex = 0;
            this.dgvKategorije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmKategorijePrikazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 358);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "frmKategorijePrikazi";
            this.Text = "Kategorije";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKategorije;
    }
}