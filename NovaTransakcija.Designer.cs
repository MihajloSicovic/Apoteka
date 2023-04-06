namespace Apoteka
{
    partial class NovaTransakcija
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
            this.label3 = new System.Windows.Forms.Label();
            this.nudKolicina = new System.Windows.Forms.NumericUpDown();
            this.btBrisi = new System.Windows.Forms.Button();
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btDodaj = new System.Windows.Forms.Button();
            this.dgRacun = new System.Windows.Forms.DataGridView();
            this.dgMagacin = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbUkupno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKartica = new System.Windows.Forms.ComboBox();
            this.cbKupac = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudKorisceniPoeni = new System.Windows.Forms.NumericUpDown();
            this.btPotvrdi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRacun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMagacin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKorisceniPoeni)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Količina:";
            // 
            // nudKolicina
            // 
            this.nudKolicina.Location = new System.Drawing.Point(379, 191);
            this.nudKolicina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKolicina.Name = "nudKolicina";
            this.nudKolicina.Size = new System.Drawing.Size(90, 20);
            this.nudKolicina.TabIndex = 36;
            this.nudKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btBrisi
            // 
            this.btBrisi.Location = new System.Drawing.Point(668, 405);
            this.btBrisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btBrisi.Name = "btBrisi";
            this.btBrisi.Size = new System.Drawing.Size(158, 35);
            this.btBrisi.TabIndex = 32;
            this.btBrisi.Text = "Obriši stavku";
            this.btBrisi.UseVisualStyleBackColor = true;
            this.btBrisi.Click += new System.EventHandler(this.btBrisi_Click);
            // 
            // btIzmeni
            // 
            this.btIzmeni.Location = new System.Drawing.Point(486, 405);
            this.btIzmeni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(158, 35);
            this.btIzmeni.TabIndex = 31;
            this.btIzmeni.Text = "Izmeni stavku";
            this.btIzmeni.UseVisualStyleBackColor = true;
            this.btIzmeni.Click += new System.EventHandler(this.btIzmeni_Click);
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(394, 234);
            this.btDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(56, 48);
            this.btDodaj.TabIndex = 30;
            this.btDodaj.Text = "---->";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // dgRacun
            // 
            this.dgRacun.AllowUserToAddRows = false;
            this.dgRacun.AllowUserToDeleteRows = false;
            this.dgRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRacun.Location = new System.Drawing.Point(486, 131);
            this.dgRacun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgRacun.MultiSelect = false;
            this.dgRacun.Name = "dgRacun";
            this.dgRacun.ReadOnly = true;
            this.dgRacun.RowHeadersVisible = false;
            this.dgRacun.RowHeadersWidth = 51;
            this.dgRacun.RowTemplate.Height = 24;
            this.dgRacun.Size = new System.Drawing.Size(340, 254);
            this.dgRacun.TabIndex = 29;
            // 
            // dgMagacin
            // 
            this.dgMagacin.AllowUserToAddRows = false;
            this.dgMagacin.AllowUserToDeleteRows = false;
            this.dgMagacin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMagacin.Location = new System.Drawing.Point(17, 131);
            this.dgMagacin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgMagacin.MultiSelect = false;
            this.dgMagacin.Name = "dgMagacin";
            this.dgMagacin.ReadOnly = true;
            this.dgMagacin.RowHeadersVisible = false;
            this.dgMagacin.RowHeadersWidth = 51;
            this.dgMagacin.RowTemplate.Height = 24;
            this.dgMagacin.Size = new System.Drawing.Size(340, 254);
            this.dgMagacin.TabIndex = 28;
            this.dgMagacin.CurrentCellChanged += new System.EventHandler(this.dgMagacin_CurrentCellChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbUkupno);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbKartica);
            this.groupBox1.Controls.Add(this.cbKupac);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudKorisceniPoeni);
            this.groupBox1.Controls.Add(this.btPotvrdi);
            this.groupBox1.Location = new System.Drawing.Point(17, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(809, 81);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // tbUkupno
            // 
            this.tbUkupno.Location = new System.Drawing.Point(492, 40);
            this.tbUkupno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUkupno.Name = "tbUkupno";
            this.tbUkupno.ReadOnly = true;
            this.tbUkupno.Size = new System.Drawing.Size(136, 20);
            this.tbUkupno.TabIndex = 30;
            this.tbUkupno.Text = "0 RSD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ukupno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Kartica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Kupac:";
            // 
            // cbKartica
            // 
            this.cbKartica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKartica.FormattingEnabled = true;
            this.cbKartica.Location = new System.Drawing.Point(316, 40);
            this.cbKartica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbKartica.Name = "cbKartica";
            this.cbKartica.Size = new System.Drawing.Size(136, 21);
            this.cbKartica.TabIndex = 26;
            this.cbKartica.SelectedValueChanged += new System.EventHandler(this.cbKartica_SelectedValueChanged);
            // 
            // cbKupac
            // 
            this.cbKupac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKupac.FormattingEnabled = true;
            this.cbKupac.Location = new System.Drawing.Point(146, 40);
            this.cbKupac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbKupac.Name = "cbKupac";
            this.cbKupac.Size = new System.Drawing.Size(136, 21);
            this.cbKupac.TabIndex = 25;
            this.cbKupac.SelectedValueChanged += new System.EventHandler(this.cbKupac_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Korišćeni poeni:";
            // 
            // nudKorisceniPoeni
            // 
            this.nudKorisceniPoeni.Location = new System.Drawing.Point(20, 40);
            this.nudKorisceniPoeni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudKorisceniPoeni.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudKorisceniPoeni.Name = "nudKorisceniPoeni";
            this.nudKorisceniPoeni.Size = new System.Drawing.Size(90, 20);
            this.nudKorisceniPoeni.TabIndex = 23;
            this.nudKorisceniPoeni.ValueChanged += new System.EventHandler(this.nudKorisceniPoeni_ValueChanged);
            // 
            // btPotvrdi
            // 
            this.btPotvrdi.Location = new System.Drawing.Point(651, 24);
            this.btPotvrdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btPotvrdi.Name = "btPotvrdi";
            this.btPotvrdi.Size = new System.Drawing.Size(154, 33);
            this.btPotvrdi.TabIndex = 22;
            this.btPotvrdi.Text = "Potvrdi transakciju";
            this.btPotvrdi.UseVisualStyleBackColor = true;
            this.btPotvrdi.Click += new System.EventHandler(this.btPotvrdi_Click);
            // 
            // NovaTransakcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 476);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudKolicina);
            this.Controls.Add(this.btBrisi);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.dgRacun);
            this.Controls.Add(this.dgMagacin);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NovaTransakcija";
            this.Text = "NovaTransakcija";
            this.Load += new System.EventHandler(this.NovaTransakcija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRacun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMagacin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKorisceniPoeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudKolicina;
        private System.Windows.Forms.Button btBrisi;
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.DataGridView dgRacun;
        private System.Windows.Forms.DataGridView dgMagacin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btPotvrdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKartica;
        private System.Windows.Forms.ComboBox cbKupac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudKorisceniPoeni;
        private System.Windows.Forms.TextBox tbUkupno;
        private System.Windows.Forms.Label label6;
    }
}