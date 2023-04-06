namespace Apoteka
{
    partial class GlavnaKupac
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lekovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lokalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iskorisceniPoeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukupnoPotrosenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lozinkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontaktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deaktivirajNalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.pregledToolStripMenuItem,
            this.podaciToolStripMenuItem,
            this.promeniToolStripMenuItem,
            this.deaktivirajNalogToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lekovaToolStripMenuItem,
            this.lokalaToolStripMenuItem});
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            // 
            // lekovaToolStripMenuItem
            // 
            this.lekovaToolStripMenuItem.Name = "lekovaToolStripMenuItem";
            this.lekovaToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.lekovaToolStripMenuItem.Tag = "Proizvod";
            this.lekovaToolStripMenuItem.Text = "Lekova";
            this.lekovaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // lokalaToolStripMenuItem
            // 
            this.lokalaToolStripMenuItem.Name = "lokalaToolStripMenuItem";
            this.lokalaToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.lokalaToolStripMenuItem.Tag = "Adresa";
            this.lokalaToolStripMenuItem.Text = "Lokala";
            this.lokalaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poeniToolStripMenuItem,
            this.iskorisceniPoeniToolStripMenuItem,
            this.ukupnoPotrosenoToolStripMenuItem});
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.pregledToolStripMenuItem.Text = "Pregled";
            // 
            // poeniToolStripMenuItem
            // 
            this.poeniToolStripMenuItem.Name = "poeniToolStripMenuItem";
            this.poeniToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.poeniToolStripMenuItem.Text = "Poeni";
            this.poeniToolStripMenuItem.Click += new System.EventHandler(this.poeniToolStripMenuItem_Click);
            // 
            // iskorisceniPoeniToolStripMenuItem
            // 
            this.iskorisceniPoeniToolStripMenuItem.Name = "iskorisceniPoeniToolStripMenuItem";
            this.iskorisceniPoeniToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.iskorisceniPoeniToolStripMenuItem.Text = "Iskorisceni poeni";
            this.iskorisceniPoeniToolStripMenuItem.Click += new System.EventHandler(this.iskorisceniPoeniToolStripMenuItem_Click);
            // 
            // ukupnoPotrosenoToolStripMenuItem
            // 
            this.ukupnoPotrosenoToolStripMenuItem.Name = "ukupnoPotrosenoToolStripMenuItem";
            this.ukupnoPotrosenoToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.ukupnoPotrosenoToolStripMenuItem.Text = "Ukupno potroseno";
            this.ukupnoPotrosenoToolStripMenuItem.Click += new System.EventHandler(this.ukupnoPotrosenoToolStripMenuItem_Click);
            // 
            // podaciToolStripMenuItem
            // 
            this.podaciToolStripMenuItem.Name = "podaciToolStripMenuItem";
            this.podaciToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.podaciToolStripMenuItem.Text = "Podaci";
            this.podaciToolStripMenuItem.Click += new System.EventHandler(this.podaciToolStripMenuItem_Click);
            // 
            // promeniToolStripMenuItem
            // 
            this.promeniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lozinkuToolStripMenuItem,
            this.kontaktToolStripMenuItem});
            this.promeniToolStripMenuItem.Name = "promeniToolStripMenuItem";
            this.promeniToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.promeniToolStripMenuItem.Text = "Promeni";
            // 
            // lozinkuToolStripMenuItem
            // 
            this.lozinkuToolStripMenuItem.Name = "lozinkuToolStripMenuItem";
            this.lozinkuToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.lozinkuToolStripMenuItem.Tag = "sifra";
            this.lozinkuToolStripMenuItem.Text = "Lozinku";
            this.lozinkuToolStripMenuItem.Click += new System.EventHandler(this.promeniToolStripMenuItem_Click);
            // 
            // kontaktToolStripMenuItem
            // 
            this.kontaktToolStripMenuItem.Name = "kontaktToolStripMenuItem";
            this.kontaktToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.kontaktToolStripMenuItem.Tag = "kontakt";
            this.kontaktToolStripMenuItem.Text = "Kontakt";
            this.kontaktToolStripMenuItem.Click += new System.EventHandler(this.promeniToolStripMenuItem_Click);
            // 
            // deaktivirajNalogToolStripMenuItem
            // 
            this.deaktivirajNalogToolStripMenuItem.Name = "deaktivirajNalogToolStripMenuItem";
            this.deaktivirajNalogToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.deaktivirajNalogToolStripMenuItem.Text = "Deaktivirajte nalog";
            this.deaktivirajNalogToolStripMenuItem.Click += new System.EventHandler(this.deaktivirajNalogToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 422);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dobrodošli";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GlavnaKupac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlavnaKupac";
            this.Text = "GlavnaKupac";
            this.Load += new System.EventHandler(this.GlavnaKupac_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukupnoPotrosenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iskorisceniPoeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lozinkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontaktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lekovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lokalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deaktivirajNalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podaciToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}