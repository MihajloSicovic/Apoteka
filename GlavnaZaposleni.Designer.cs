namespace Apoteka
{
    partial class GlavnaZaposleni
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
            this.novaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dostavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transakcijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magacinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposlenihToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lokalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dostaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transakcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lozinkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brojRacunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deaktivirajteNalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.nalogZaposlenogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaToolStripMenuItem,
            this.pregledToolStripMenuItem,
            this.karticeToolStripMenuItem,
            this.dostaveToolStripMenuItem,
            this.transakcijeToolStripMenuItem,
            this.podaciToolStripMenuItem,
            this.promeniToolStripMenuItem,
            this.deaktivirajteNalogToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novaToolStripMenuItem
            // 
            this.novaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.karticaToolStripMenuItem,
            this.dostavaToolStripMenuItem,
            this.transakcijaToolStripMenuItem,
            this.nalogZaposlenogToolStripMenuItem});
            this.novaToolStripMenuItem.Name = "novaToolStripMenuItem";
            this.novaToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.novaToolStripMenuItem.Text = "Nova";
            // 
            // karticaToolStripMenuItem
            // 
            this.karticaToolStripMenuItem.Name = "karticaToolStripMenuItem";
            this.karticaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.karticaToolStripMenuItem.Text = "Kartica";
            this.karticaToolStripMenuItem.Click += new System.EventHandler(this.karticaToolStripMenuItem_Click);
            // 
            // dostavaToolStripMenuItem
            // 
            this.dostavaToolStripMenuItem.Name = "dostavaToolStripMenuItem";
            this.dostavaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dostavaToolStripMenuItem.Text = "Dostava";
            this.dostavaToolStripMenuItem.Click += new System.EventHandler(this.dostavaToolStripMenuItem_Click);
            // 
            // transakcijaToolStripMenuItem
            // 
            this.transakcijaToolStripMenuItem.Name = "transakcijaToolStripMenuItem";
            this.transakcijaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.transakcijaToolStripMenuItem.Text = "Transakcija";
            this.transakcijaToolStripMenuItem.Click += new System.EventHandler(this.transakcijaToolStripMenuItem_Click);
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proizvodaToolStripMenuItem,
            this.magacinaToolStripMenuItem,
            this.zaposlenihToolStripMenuItem,
            this.lokalaToolStripMenuItem});
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.pregledToolStripMenuItem.Text = "Pregled";
            // 
            // proizvodaToolStripMenuItem
            // 
            this.proizvodaToolStripMenuItem.Name = "proizvodaToolStripMenuItem";
            this.proizvodaToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.proizvodaToolStripMenuItem.Text = "Proizvoda";
            this.proizvodaToolStripMenuItem.Click += new System.EventHandler(this.proizvodaToolStripMenuItem_Click);
            // 
            // magacinaToolStripMenuItem
            // 
            this.magacinaToolStripMenuItem.Name = "magacinaToolStripMenuItem";
            this.magacinaToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.magacinaToolStripMenuItem.Text = "Magacina";
            this.magacinaToolStripMenuItem.Click += new System.EventHandler(this.magacinaToolStripMenuItem_Click);
            // 
            // zaposlenihToolStripMenuItem
            // 
            this.zaposlenihToolStripMenuItem.Name = "zaposlenihToolStripMenuItem";
            this.zaposlenihToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.zaposlenihToolStripMenuItem.Text = "Zaposlenih";
            this.zaposlenihToolStripMenuItem.Click += new System.EventHandler(this.zaposlenihToolStripMenuItem_Click);
            // 
            // lokalaToolStripMenuItem
            // 
            this.lokalaToolStripMenuItem.Name = "lokalaToolStripMenuItem";
            this.lokalaToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.lokalaToolStripMenuItem.Text = "Lokala";
            this.lokalaToolStripMenuItem.Visible = false;
            this.lokalaToolStripMenuItem.Click += new System.EventHandler(this.lokalaToolStripMenuItem_Click);
            // 
            // karticeToolStripMenuItem
            // 
            this.karticeToolStripMenuItem.Name = "karticeToolStripMenuItem";
            this.karticeToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.karticeToolStripMenuItem.Text = "Kartice";
            this.karticeToolStripMenuItem.Click += new System.EventHandler(this.karticeToolStripMenuItem_Click);
            // 
            // dostaveToolStripMenuItem
            // 
            this.dostaveToolStripMenuItem.Name = "dostaveToolStripMenuItem";
            this.dostaveToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.dostaveToolStripMenuItem.Text = "Dostave";
            this.dostaveToolStripMenuItem.Click += new System.EventHandler(this.dostaveToolStripMenuItem_Click);
            // 
            // transakcijeToolStripMenuItem
            // 
            this.transakcijeToolStripMenuItem.Name = "transakcijeToolStripMenuItem";
            this.transakcijeToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.transakcijeToolStripMenuItem.Text = "Transakcije";
            this.transakcijeToolStripMenuItem.Click += new System.EventHandler(this.transakcijeToolStripMenuItem_Click);
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
            this.brojRacunaToolStripMenuItem});
            this.promeniToolStripMenuItem.Name = "promeniToolStripMenuItem";
            this.promeniToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.promeniToolStripMenuItem.Text = "Promeni";
            // 
            // lozinkuToolStripMenuItem
            // 
            this.lozinkuToolStripMenuItem.Name = "lozinkuToolStripMenuItem";
            this.lozinkuToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.lozinkuToolStripMenuItem.Tag = "sifra";
            this.lozinkuToolStripMenuItem.Text = "Lozinku";
            this.lozinkuToolStripMenuItem.Click += new System.EventHandler(this.promeniToolStripMenuItem_Click);
            // 
            // brojRacunaToolStripMenuItem
            // 
            this.brojRacunaToolStripMenuItem.Name = "brojRacunaToolStripMenuItem";
            this.brojRacunaToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.brojRacunaToolStripMenuItem.Tag = "Broj racuna";
            this.brojRacunaToolStripMenuItem.Text = "Broj racuna";
            this.brojRacunaToolStripMenuItem.Click += new System.EventHandler(this.promeniToolStripMenuItem_Click);
            // 
            // deaktivirajteNalogToolStripMenuItem
            // 
            this.deaktivirajteNalogToolStripMenuItem.Name = "deaktivirajteNalogToolStripMenuItem";
            this.deaktivirajteNalogToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.deaktivirajteNalogToolStripMenuItem.Text = "Deaktivirajte nalog";
            this.deaktivirajteNalogToolStripMenuItem.Click += new System.EventHandler(this.deaktivirajteNalogToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 422);
            this.label1.TabIndex = 2;
            this.label1.Text = "Srećan rad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nalogZaposlenogToolStripMenuItem
            // 
            this.nalogZaposlenogToolStripMenuItem.Name = "nalogZaposlenogToolStripMenuItem";
            this.nalogZaposlenogToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nalogZaposlenogToolStripMenuItem.Text = "Nalog zaposlenog";
            this.nalogZaposlenogToolStripMenuItem.Visible = false;
            this.nalogZaposlenogToolStripMenuItem.Click += new System.EventHandler(this.nalogZaposlenogToolStripMenuItem_Click);
            // 
            // GlavnaZaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlavnaZaposleni";
            this.Text = "GlavnaZaposleni";
            this.Load += new System.EventHandler(this.GlavnaZaposleni_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem karticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dostavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transakcijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magacinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposlenihToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lozinkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deaktivirajteNalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brojRacunaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem podaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lokalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem karticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dostaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transakcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nalogZaposlenogToolStripMenuItem;
    }
}