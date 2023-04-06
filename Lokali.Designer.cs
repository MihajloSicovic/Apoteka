namespace Apoteka
{
    partial class Lokali
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
            this.tbKontakt = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgLokali = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLokali)).BeginInit();
            this.SuspendLayout();
            // 
            // btIzmeni
            // 
            this.btIzmeni.Location = new System.Drawing.Point(303, 374);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(197, 52);
            this.btIzmeni.TabIndex = 26;
            this.btIzmeni.Text = "Izmeni";
            this.btIzmeni.UseVisualStyleBackColor = true;
            this.btIzmeni.Click += new System.EventHandler(this.btIzmeni_Click);
            // 
            // btBrisi
            // 
            this.btBrisi.Location = new System.Drawing.Point(556, 374);
            this.btBrisi.Name = "btBrisi";
            this.btBrisi.Size = new System.Drawing.Size(197, 52);
            this.btBrisi.TabIndex = 25;
            this.btBrisi.Text = "Briši";
            this.btBrisi.UseVisualStyleBackColor = true;
            this.btBrisi.Click += new System.EventHandler(this.btBrisi_Click);
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(50, 374);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(197, 52);
            this.btDodaj.TabIndex = 24;
            this.btDodaj.Text = "Dodaj";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // tbKontakt
            // 
            this.tbKontakt.Location = new System.Drawing.Point(286, 44);
            this.tbKontakt.Name = "tbKontakt";
            this.tbKontakt.Size = new System.Drawing.Size(181, 22);
            this.tbKontakt.TabIndex = 20;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(50, 44);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(181, 22);
            this.tbAdresa.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kontakt:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Adresa:";
            // 
            // dgLokali
            // 
            this.dgLokali.AllowUserToAddRows = false;
            this.dgLokali.AllowUserToDeleteRows = false;
            this.dgLokali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLokali.Location = new System.Drawing.Point(50, 72);
            this.dgLokali.MultiSelect = false;
            this.dgLokali.Name = "dgLokali";
            this.dgLokali.ReadOnly = true;
            this.dgLokali.RowHeadersVisible = false;
            this.dgLokali.RowHeadersWidth = 51;
            this.dgLokali.RowTemplate.Height = 24;
            this.dgLokali.Size = new System.Drawing.Size(703, 287);
            this.dgLokali.TabIndex = 14;
            this.dgLokali.CurrentCellChanged += new System.EventHandler(this.dgLokali_CurrentCellChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(98, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "*";
            // 
            // Lokali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btBrisi);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.tbKontakt);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgLokali);
            this.Name = "Lokali";
            this.Text = "Lokali";
            this.Load += new System.EventHandler(this.Lokali_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLokali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btBrisi;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.TextBox tbKontakt;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgLokali;
        private System.Windows.Forms.Label label9;
    }
}