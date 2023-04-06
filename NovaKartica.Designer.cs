namespace Apoteka
{
    partial class NovaKartica
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBrojKartice = new System.Windows.Forms.TextBox();
            this.cbTipKartice = new System.Windows.Forms.ComboBox();
            this.cbKupac = new System.Windows.Forms.ComboBox();
            this.btDodaj = new System.Windows.Forms.Button();
            this.nudPoeni = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoeni)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj kartice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Poeni:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tip kartice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kupac:";
            // 
            // tbBrojKartice
            // 
            this.tbBrojKartice.Location = new System.Drawing.Point(239, 73);
            this.tbBrojKartice.Name = "tbBrojKartice";
            this.tbBrojKartice.Size = new System.Drawing.Size(121, 22);
            this.tbBrojKartice.TabIndex = 4;
            // 
            // cbTipKartice
            // 
            this.cbTipKartice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipKartice.FormattingEnabled = true;
            this.cbTipKartice.Location = new System.Drawing.Point(239, 191);
            this.cbTipKartice.Name = "cbTipKartice";
            this.cbTipKartice.Size = new System.Drawing.Size(121, 24);
            this.cbTipKartice.TabIndex = 6;
            // 
            // cbKupac
            // 
            this.cbKupac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKupac.FormattingEnabled = true;
            this.cbKupac.Location = new System.Drawing.Point(239, 252);
            this.cbKupac.Name = "cbKupac";
            this.cbKupac.Size = new System.Drawing.Size(121, 24);
            this.cbKupac.TabIndex = 7;
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(147, 314);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(213, 38);
            this.btDodaj.TabIndex = 8;
            this.btDodaj.Text = "Dodajte novu karticu";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // nudPoeni
            // 
            this.nudPoeni.Location = new System.Drawing.Point(239, 133);
            this.nudPoeni.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPoeni.Name = "nudPoeni";
            this.nudPoeni.Size = new System.Drawing.Size(121, 22);
            this.nudPoeni.TabIndex = 9;
            // 
            // NovaKartica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.nudPoeni);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.cbKupac);
            this.Controls.Add(this.cbTipKartice);
            this.Controls.Add(this.tbBrojKartice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NovaKartica";
            this.Text = "NovaKartica";
            this.Load += new System.EventHandler(this.NovaKartica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPoeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBrojKartice;
        private System.Windows.Forms.ComboBox cbTipKartice;
        private System.Windows.Forms.ComboBox cbKupac;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.NumericUpDown nudPoeni;
    }
}