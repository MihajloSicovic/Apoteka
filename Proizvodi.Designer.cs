namespace Apoteka
{
    partial class Proizvodi
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
            this.dgProizvodi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.tbPodvrsta = new System.Windows.Forms.TextBox();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.cbLek = new System.Windows.Forms.CheckBox();
            this.btDodaj = new System.Windows.Forms.Button();
            this.btBrisi = new System.Windows.Forms.Button();
            this.btIzmeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProizvodi
            // 
            this.dgProizvodi.AllowUserToAddRows = false;
            this.dgProizvodi.AllowUserToDeleteRows = false;
            this.dgProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProizvodi.Location = new System.Drawing.Point(51, 130);
            this.dgProizvodi.MultiSelect = false;
            this.dgProizvodi.Name = "dgProizvodi";
            this.dgProizvodi.ReadOnly = true;
            this.dgProizvodi.RowHeadersVisible = false;
            this.dgProizvodi.RowHeadersWidth = 51;
            this.dgProizvodi.RowTemplate.Height = 24;
            this.dgProizvodi.Size = new System.Drawing.Size(703, 287);
            this.dgProizvodi.TabIndex = 0;
            this.dgProizvodi.CurrentCellChanged += new System.EventHandler(this.dgProizvodi_CurrentCellChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Podvrsta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Opis:";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(51, 102);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(100, 22);
            this.tbNaziv.TabIndex = 6;
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(198, 102);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(100, 22);
            this.tbCena.TabIndex = 7;
            // 
            // tbPodvrsta
            // 
            this.tbPodvrsta.Location = new System.Drawing.Point(345, 102);
            this.tbPodvrsta.Name = "tbPodvrsta";
            this.tbPodvrsta.Size = new System.Drawing.Size(100, 22);
            this.tbPodvrsta.TabIndex = 8;
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(492, 102);
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(176, 22);
            this.tbOpis.TabIndex = 9;
            // 
            // cbLek
            // 
            this.cbLek.AutoSize = true;
            this.cbLek.Location = new System.Drawing.Point(703, 104);
            this.cbLek.Name = "cbLek";
            this.cbLek.Size = new System.Drawing.Size(51, 20);
            this.cbLek.TabIndex = 10;
            this.cbLek.Text = "Lek";
            this.cbLek.UseVisualStyleBackColor = true;
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(51, 432);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(197, 52);
            this.btDodaj.TabIndex = 11;
            this.btDodaj.Text = "Dodaj";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // btBrisi
            // 
            this.btBrisi.Location = new System.Drawing.Point(557, 432);
            this.btBrisi.Name = "btBrisi";
            this.btBrisi.Size = new System.Drawing.Size(197, 52);
            this.btBrisi.TabIndex = 12;
            this.btBrisi.Text = "Briši";
            this.btBrisi.UseVisualStyleBackColor = true;
            this.btBrisi.Click += new System.EventHandler(this.btBrisi_Click);
            // 
            // btIzmeni
            // 
            this.btIzmeni.Location = new System.Drawing.Point(304, 432);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(197, 52);
            this.btIzmeni.TabIndex = 13;
            this.btIzmeni.Text = "Izmeni";
            this.btIzmeni.UseVisualStyleBackColor = true;
            this.btIzmeni.Click += new System.EventHandler(this.btIzmeni_Click);
            // 
            // Proizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 525);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btBrisi);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.cbLek);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.tbPodvrsta);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgProizvodi);
            this.Name = "Proizvodi";
            this.Text = "Proizvodi";
            this.Load += new System.EventHandler(this.Proizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProizvodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.TextBox tbPodvrsta;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.CheckBox cbLek;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.Button btBrisi;
        private System.Windows.Forms.Button btIzmeni;
    }
}