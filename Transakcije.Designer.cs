namespace Apoteka
{
    partial class Transakcije
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
            this.cbKupac = new System.Windows.Forms.ComboBox();
            this.cbKartica = new System.Windows.Forms.ComboBox();
            this.nudKorisceniPoeni = new System.Windows.Forms.NumericUpDown();
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btBrisi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgTransakcije = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudKorisceniPoeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransakcije)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKupac
            // 
            this.cbKupac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKupac.FormattingEnabled = true;
            this.cbKupac.Location = new System.Drawing.Point(330, 44);
            this.cbKupac.Name = "cbKupac";
            this.cbKupac.Size = new System.Drawing.Size(143, 24);
            this.cbKupac.TabIndex = 67;
            // 
            // cbKartica
            // 
            this.cbKartica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKartica.FormattingEnabled = true;
            this.cbKartica.Location = new System.Drawing.Point(610, 42);
            this.cbKartica.Name = "cbKartica";
            this.cbKartica.Size = new System.Drawing.Size(143, 24);
            this.cbKartica.TabIndex = 66;
            // 
            // nudKorisceniPoeni
            // 
            this.nudKorisceniPoeni.Location = new System.Drawing.Point(50, 44);
            this.nudKorisceniPoeni.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudKorisceniPoeni.Name = "nudKorisceniPoeni";
            this.nudKorisceniPoeni.Size = new System.Drawing.Size(143, 22);
            this.nudKorisceniPoeni.TabIndex = 65;
            // 
            // btIzmeni
            // 
            this.btIzmeni.Location = new System.Drawing.Point(50, 374);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(339, 52);
            this.btIzmeni.TabIndex = 63;
            this.btIzmeni.Text = "Izmeni";
            this.btIzmeni.UseVisualStyleBackColor = true;
            this.btIzmeni.Click += new System.EventHandler(this.btIzmeni_Click);
            // 
            // btBrisi
            // 
            this.btBrisi.Location = new System.Drawing.Point(412, 374);
            this.btBrisi.Name = "btBrisi";
            this.btBrisi.Size = new System.Drawing.Size(341, 52);
            this.btBrisi.TabIndex = 62;
            this.btBrisi.Text = "Briši";
            this.btBrisi.UseVisualStyleBackColor = true;
            this.btBrisi.Click += new System.EventHandler(this.btBrisi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 61;
            this.label5.Text = "Kupac:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Kartica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Korišćeni poeni:";
            // 
            // dgTransakcije
            // 
            this.dgTransakcije.AllowUserToAddRows = false;
            this.dgTransakcije.AllowUserToDeleteRows = false;
            this.dgTransakcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransakcije.Location = new System.Drawing.Point(50, 72);
            this.dgTransakcije.MultiSelect = false;
            this.dgTransakcije.Name = "dgTransakcije";
            this.dgTransakcije.ReadOnly = true;
            this.dgTransakcije.RowHeadersVisible = false;
            this.dgTransakcije.RowHeadersWidth = 51;
            this.dgTransakcije.RowTemplate.Height = 24;
            this.dgTransakcije.Size = new System.Drawing.Size(703, 287);
            this.dgTransakcije.TabIndex = 57;
            this.dgTransakcije.CurrentCellChanged += new System.EventHandler(this.dgTransakcije_CurrentCellChanged);
            // 
            // Transakcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbKupac);
            this.Controls.Add(this.cbKartica);
            this.Controls.Add(this.nudKorisceniPoeni);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btBrisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgTransakcije);
            this.Name = "Transakcije";
            this.Text = "Transakcije";
            this.Load += new System.EventHandler(this.Transakcije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKorisceniPoeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransakcije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKupac;
        private System.Windows.Forms.ComboBox cbKartica;
        private System.Windows.Forms.NumericUpDown nudKorisceniPoeni;
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btBrisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgTransakcije;
    }
}