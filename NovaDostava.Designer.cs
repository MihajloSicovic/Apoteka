namespace Apoteka
{
    partial class NovaDostava
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
            this.dgProizvod = new System.Windows.Forms.DataGridView();
            this.dgMagacin = new System.Windows.Forms.DataGridView();
            this.btDodaj = new System.Windows.Forms.Button();
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btBrisi = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btPotvrdi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpRokTrajanja = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.nudKolicina = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMagacin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProizvod
            // 
            this.dgProizvod.AllowUserToAddRows = false;
            this.dgProizvod.AllowUserToDeleteRows = false;
            this.dgProizvod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProizvod.Location = new System.Drawing.Point(12, 92);
            this.dgProizvod.MultiSelect = false;
            this.dgProizvod.Name = "dgProizvod";
            this.dgProizvod.ReadOnly = true;
            this.dgProizvod.RowHeadersVisible = false;
            this.dgProizvod.RowHeadersWidth = 51;
            this.dgProizvod.RowTemplate.Height = 24;
            this.dgProizvod.Size = new System.Drawing.Size(454, 313);
            this.dgProizvod.TabIndex = 15;
            this.dgProizvod.CurrentCellChanged += new System.EventHandler(this.dgProizvod_CurrentCellChanged);
            // 
            // dgMagacin
            // 
            this.dgMagacin.AllowUserToAddRows = false;
            this.dgMagacin.AllowUserToDeleteRows = false;
            this.dgMagacin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMagacin.Location = new System.Drawing.Point(637, 92);
            this.dgMagacin.MultiSelect = false;
            this.dgMagacin.Name = "dgMagacin";
            this.dgMagacin.ReadOnly = true;
            this.dgMagacin.RowHeadersVisible = false;
            this.dgMagacin.RowHeadersWidth = 51;
            this.dgMagacin.RowTemplate.Height = 24;
            this.dgMagacin.Size = new System.Drawing.Size(454, 313);
            this.dgMagacin.TabIndex = 16;
            this.dgMagacin.CurrentCellChanged += new System.EventHandler(this.dgMagacin_CurrentCellChanged);
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(514, 219);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(75, 59);
            this.btDodaj.TabIndex = 17;
            this.btDodaj.Text = "---->";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // btIzmeni
            // 
            this.btIzmeni.Location = new System.Drawing.Point(637, 429);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(211, 43);
            this.btIzmeni.TabIndex = 18;
            this.btIzmeni.Text = "Izmeni stavku";
            this.btIzmeni.UseVisualStyleBackColor = true;
            this.btIzmeni.Click += new System.EventHandler(this.btIzmeni_Click);
            // 
            // btBrisi
            // 
            this.btBrisi.Location = new System.Drawing.Point(880, 429);
            this.btBrisi.Name = "btBrisi";
            this.btBrisi.Size = new System.Drawing.Size(211, 43);
            this.btBrisi.TabIndex = 19;
            this.btBrisi.Text = "Obriši stavku";
            this.btBrisi.UseVisualStyleBackColor = true;
            this.btBrisi.Click += new System.EventHandler(this.btBrisi_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(15, 49);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(211, 22);
            this.dtpDatum.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Datum isporuke:";
            // 
            // btPotvrdi
            // 
            this.btPotvrdi.Location = new System.Drawing.Point(243, 30);
            this.btPotvrdi.Name = "btPotvrdi";
            this.btPotvrdi.Size = new System.Drawing.Size(205, 41);
            this.btPotvrdi.TabIndex = 22;
            this.btPotvrdi.Text = "Potvrdi dostavu";
            this.btPotvrdi.UseVisualStyleBackColor = true;
            this.btPotvrdi.Click += new System.EventHandler(this.btPotvrdi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btPotvrdi);
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(637, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 100);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // dtpRokTrajanja
            // 
            this.dtpRokTrajanja.Location = new System.Drawing.Point(356, 44);
            this.dtpRokTrajanja.Name = "dtpRokTrajanja";
            this.dtpRokTrajanja.ShowCheckBox = true;
            this.dtpRokTrajanja.Size = new System.Drawing.Size(200, 22);
            this.dtpRokTrajanja.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Rok trajanja:";
            // 
            // nudKolicina
            // 
            this.nudKolicina.Location = new System.Drawing.Point(603, 44);
            this.nudKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKolicina.Name = "nudKolicina";
            this.nudKolicina.Size = new System.Drawing.Size(120, 22);
            this.nudKolicina.TabIndex = 26;
            this.nudKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Količina:";
            // 
            // NovaDostava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 620);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudKolicina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpRokTrajanja);
            this.Controls.Add(this.btBrisi);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.dgMagacin);
            this.Controls.Add(this.dgProizvod);
            this.Controls.Add(this.groupBox1);
            this.Name = "NovaDostava";
            this.Text = "NovaDostava";
            this.Load += new System.EventHandler(this.NovaDostava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMagacin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProizvod;
        private System.Windows.Forms.DataGridView dgMagacin;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btBrisi;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPotvrdi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpRokTrajanja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudKolicina;
        private System.Windows.Forms.Label label3;
    }
}