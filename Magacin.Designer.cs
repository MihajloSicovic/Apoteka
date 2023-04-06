namespace Apoteka
{
    partial class Magacin
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
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btBrisi = new System.Windows.Forms.Button();
            this.btDodaj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgMagacin = new System.Windows.Forms.DataGridView();
            this.dtpDostavljeno = new System.Windows.Forms.DateTimePicker();
            this.dtpRokTrajanja = new System.Windows.Forms.DateTimePicker();
            this.nudKolicina = new System.Windows.Forms.NumericUpDown();
            this.btRegulisi = new System.Windows.Forms.Button();
            this.cbNaziv = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMagacin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // btIzmeni
            // 
            this.btIzmeni.Location = new System.Drawing.Point(231, 374);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(158, 52);
            this.btIzmeni.TabIndex = 26;
            this.btIzmeni.Text = "Izmeni";
            this.btIzmeni.UseVisualStyleBackColor = true;
            this.btIzmeni.Click += new System.EventHandler(this.btIzmeni_Click);
            // 
            // btBrisi
            // 
            this.btBrisi.Location = new System.Drawing.Point(412, 374);
            this.btBrisi.Name = "btBrisi";
            this.btBrisi.Size = new System.Drawing.Size(158, 52);
            this.btBrisi.TabIndex = 25;
            this.btBrisi.Text = "Briši";
            this.btBrisi.UseVisualStyleBackColor = true;
            this.btBrisi.Click += new System.EventHandler(this.btBrisi_Click);
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(50, 374);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(158, 52);
            this.btDodaj.TabIndex = 24;
            this.btDodaj.Text = "Dodaj";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Količina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Rok trajanja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Dostavljeno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Naziv leka:";
            // 
            // dgMagacin
            // 
            this.dgMagacin.AllowUserToAddRows = false;
            this.dgMagacin.AllowUserToDeleteRows = false;
            this.dgMagacin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMagacin.Location = new System.Drawing.Point(50, 72);
            this.dgMagacin.MultiSelect = false;
            this.dgMagacin.Name = "dgMagacin";
            this.dgMagacin.ReadOnly = true;
            this.dgMagacin.RowHeadersVisible = false;
            this.dgMagacin.RowHeadersWidth = 51;
            this.dgMagacin.RowTemplate.Height = 24;
            this.dgMagacin.Size = new System.Drawing.Size(703, 287);
            this.dgMagacin.TabIndex = 14;
            this.dgMagacin.CurrentCellChanged += new System.EventHandler(this.dgMagacin_CurrentCellChanged);
            // 
            // dtpDostavljeno
            // 
            this.dtpDostavljeno.Enabled = false;
            this.dtpDostavljeno.Location = new System.Drawing.Point(242, 44);
            this.dtpDostavljeno.Name = "dtpDostavljeno";
            this.dtpDostavljeno.ShowCheckBox = true;
            this.dtpDostavljeno.Size = new System.Drawing.Size(164, 22);
            this.dtpDostavljeno.TabIndex = 27;
            // 
            // dtpRokTrajanja
            // 
            this.dtpRokTrajanja.Location = new System.Drawing.Point(448, 44);
            this.dtpRokTrajanja.Name = "dtpRokTrajanja";
            this.dtpRokTrajanja.ShowCheckBox = true;
            this.dtpRokTrajanja.Size = new System.Drawing.Size(164, 22);
            this.dtpRokTrajanja.TabIndex = 28;
            // 
            // nudKolicina
            // 
            this.nudKolicina.Location = new System.Drawing.Point(654, 44);
            this.nudKolicina.Name = "nudKolicina";
            this.nudKolicina.Size = new System.Drawing.Size(97, 22);
            this.nudKolicina.TabIndex = 29;
            // 
            // btRegulisi
            // 
            this.btRegulisi.Location = new System.Drawing.Point(593, 374);
            this.btRegulisi.Name = "btRegulisi";
            this.btRegulisi.Size = new System.Drawing.Size(158, 52);
            this.btRegulisi.TabIndex = 30;
            this.btRegulisi.Text = "Reguliši magacin";
            this.btRegulisi.UseVisualStyleBackColor = true;
            this.btRegulisi.Click += new System.EventHandler(this.btRegulisi_Click);
            // 
            // cbNaziv
            // 
            this.cbNaziv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNaziv.FormattingEnabled = true;
            this.cbNaziv.Location = new System.Drawing.Point(50, 44);
            this.cbNaziv.Name = "cbNaziv";
            this.cbNaziv.Size = new System.Drawing.Size(150, 24);
            this.cbNaziv.TabIndex = 31;
            // 
            // Magacin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbNaziv);
            this.Controls.Add(this.btRegulisi);
            this.Controls.Add(this.nudKolicina);
            this.Controls.Add(this.dtpRokTrajanja);
            this.Controls.Add(this.dtpDostavljeno);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btBrisi);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgMagacin);
            this.Name = "Magacin";
            this.Text = "Magacin";
            this.Load += new System.EventHandler(this.Magacin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMagacin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btBrisi;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgMagacin;
        private System.Windows.Forms.DateTimePicker dtpDostavljeno;
        private System.Windows.Forms.DateTimePicker dtpRokTrajanja;
        private System.Windows.Forms.NumericUpDown nudKolicina;
        private System.Windows.Forms.Button btRegulisi;
        private System.Windows.Forms.ComboBox cbNaziv;
    }
}