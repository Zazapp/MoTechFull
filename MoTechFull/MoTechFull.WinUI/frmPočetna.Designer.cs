﻿
namespace MoTechFull.WinUI
{
    partial class frmPocetna
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.artikliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUrediKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKategorijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUrediKategorijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodjaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledProizvodjacaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUrediProizvodjacaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kantoniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKantonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUrediKantonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledGradovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUrediGradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.sHOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artikliToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.kategorijeToolStripMenuItem,
            this.proizvodjaciToolStripMenuItem,
            this.kantoniToolStripMenuItem,
            this.gradoviToolStripMenuItem,
            this.sHOPToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // artikliToolStripMenuItem
            // 
            this.artikliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem,
            this.dodajToolStripMenuItem});
            this.artikliToolStripMenuItem.Name = "artikliToolStripMenuItem";
            this.artikliToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.artikliToolStripMenuItem.Text = "Artikli";
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pregledToolStripMenuItem.Text = "Pregled Artikala";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.pregledToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj Uredi Artikal";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKorisnikaToolStripMenuItem,
            this.dodajUrediKorisnikaToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // pregledKorisnikaToolStripMenuItem
            // 
            this.pregledKorisnikaToolStripMenuItem.Name = "pregledKorisnikaToolStripMenuItem";
            this.pregledKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.pregledKorisnikaToolStripMenuItem.Text = "Pregled Korisnika";
            this.pregledKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.pregledKorisnikaToolStripMenuItem_Click);
            // 
            // dodajUrediKorisnikaToolStripMenuItem
            // 
            this.dodajUrediKorisnikaToolStripMenuItem.Name = "dodajUrediKorisnikaToolStripMenuItem";
            this.dodajUrediKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.dodajUrediKorisnikaToolStripMenuItem.Text = "Dodaj Uredi Korisnika";
            this.dodajUrediKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajUrediKorisnikaToolStripMenuItem_Click);
            // 
            // kategorijeToolStripMenuItem
            // 
            this.kategorijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKategorijaToolStripMenuItem,
            this.dodajUrediKategorijuToolStripMenuItem});
            this.kategorijeToolStripMenuItem.Name = "kategorijeToolStripMenuItem";
            this.kategorijeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.kategorijeToolStripMenuItem.Text = "Kategorije";
            // 
            // pregledKategorijaToolStripMenuItem
            // 
            this.pregledKategorijaToolStripMenuItem.Name = "pregledKategorijaToolStripMenuItem";
            this.pregledKategorijaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.pregledKategorijaToolStripMenuItem.Text = "Pregled Kategorija";
            this.pregledKategorijaToolStripMenuItem.Click += new System.EventHandler(this.pregledKategorijaToolStripMenuItem_Click);
            // 
            // dodajUrediKategorijuToolStripMenuItem
            // 
            this.dodajUrediKategorijuToolStripMenuItem.Name = "dodajUrediKategorijuToolStripMenuItem";
            this.dodajUrediKategorijuToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.dodajUrediKategorijuToolStripMenuItem.Text = "Dodaj Uredi Kategoriju";
            this.dodajUrediKategorijuToolStripMenuItem.Click += new System.EventHandler(this.dodajUrediKategorijuToolStripMenuItem_Click);
            // 
            // proizvodjaciToolStripMenuItem
            // 
            this.proizvodjaciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledProizvodjacaToolStripMenuItem,
            this.dodajUrediProizvodjacaToolStripMenuItem});
            this.proizvodjaciToolStripMenuItem.Name = "proizvodjaciToolStripMenuItem";
            this.proizvodjaciToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.proizvodjaciToolStripMenuItem.Text = "Proizvodjaci";
            // 
            // pregledProizvodjacaToolStripMenuItem
            // 
            this.pregledProizvodjacaToolStripMenuItem.Name = "pregledProizvodjacaToolStripMenuItem";
            this.pregledProizvodjacaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.pregledProizvodjacaToolStripMenuItem.Text = "Pregled Proizvodjaca";
            this.pregledProizvodjacaToolStripMenuItem.Click += new System.EventHandler(this.pregledProizvodjacaToolStripMenuItem_Click);
            // 
            // dodajUrediProizvodjacaToolStripMenuItem
            // 
            this.dodajUrediProizvodjacaToolStripMenuItem.Name = "dodajUrediProizvodjacaToolStripMenuItem";
            this.dodajUrediProizvodjacaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.dodajUrediProizvodjacaToolStripMenuItem.Text = "Dodaj Uredi Proizvodjaca";
            this.dodajUrediProizvodjacaToolStripMenuItem.Click += new System.EventHandler(this.dodajUrediProizvodjacaToolStripMenuItem_Click);
            // 
            // kantoniToolStripMenuItem
            // 
            this.kantoniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKantonaToolStripMenuItem,
            this.dodajUrediKantonToolStripMenuItem});
            this.kantoniToolStripMenuItem.Name = "kantoniToolStripMenuItem";
            this.kantoniToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.kantoniToolStripMenuItem.Text = "Kantoni";
            // 
            // pregledKantonaToolStripMenuItem
            // 
            this.pregledKantonaToolStripMenuItem.Name = "pregledKantonaToolStripMenuItem";
            this.pregledKantonaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.pregledKantonaToolStripMenuItem.Text = "Pregled Kantona";
            this.pregledKantonaToolStripMenuItem.Click += new System.EventHandler(this.pregledKantonaToolStripMenuItem_Click);
            // 
            // dodajUrediKantonToolStripMenuItem
            // 
            this.dodajUrediKantonToolStripMenuItem.Name = "dodajUrediKantonToolStripMenuItem";
            this.dodajUrediKantonToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.dodajUrediKantonToolStripMenuItem.Text = "Dodaj Uredi Kanton";
            this.dodajUrediKantonToolStripMenuItem.Click += new System.EventHandler(this.dodajUrediKantonToolStripMenuItem_Click);
            // 
            // gradoviToolStripMenuItem
            // 
            this.gradoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledGradovaToolStripMenuItem,
            this.dodajUrediGradToolStripMenuItem});
            this.gradoviToolStripMenuItem.Name = "gradoviToolStripMenuItem";
            this.gradoviToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.gradoviToolStripMenuItem.Text = "Gradovi";
            // 
            // pregledGradovaToolStripMenuItem
            // 
            this.pregledGradovaToolStripMenuItem.Name = "pregledGradovaToolStripMenuItem";
            this.pregledGradovaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pregledGradovaToolStripMenuItem.Text = "Pregled Gradova";
            this.pregledGradovaToolStripMenuItem.Click += new System.EventHandler(this.pregledGradovaToolStripMenuItem_Click);
            // 
            // dodajUrediGradToolStripMenuItem
            // 
            this.dodajUrediGradToolStripMenuItem.Name = "dodajUrediGradToolStripMenuItem";
            this.dodajUrediGradToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dodajUrediGradToolStripMenuItem.Text = "Dodaj Uredi Grad";
            this.dodajUrediGradToolStripMenuItem.Click += new System.EventHandler(this.dodajUrediGradToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // sHOPToolStripMenuItem
            // 
            this.sHOPToolStripMenuItem.Name = "sHOPToolStripMenuItem";
            this.sHOPToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sHOPToolStripMenuItem.Text = "SHOP";
            this.sHOPToolStripMenuItem.Click += new System.EventHandler(this.sHOPToolStripMenuItem_Click);
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPocetna";
            this.Text = "MoTech PC Shop";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem artikliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUrediKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKategorijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUrediKategorijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodjaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledProizvodjacaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUrediProizvodjacaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kantoniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKantonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUrediKantonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledGradovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUrediGradToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHOPToolStripMenuItem;
    }
}



