namespace Apoteka
{
    partial class Kartice
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgKartice = new System.Windows.Forms.DataGridView();
            this.tbBrojKartice = new System.Windows.Forms.TextBox();
            this.nudPoeni = new System.Windows.Forms.NumericUpDown();
            this.cbTipKartice = new System.Windows.Forms.ComboBox();
            this.cbKupac = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgKartice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoeni)).BeginInit();
            this.SuspendLayout();
            // 
            // btIzmeni
            // 
            this.btIzmeni.Location = new System.Drawing.Point(50, 374);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(339, 52);
            this.btIzmeni.TabIndex = 52;
            this.btIzmeni.Text = "Izmeni";
            this.btIzmeni.UseVisualStyleBackColor = true;
            this.btIzmeni.Click += new System.EventHandler(this.btIzmeni_Click);
            // 
            // btBrisi
            // 
            this.btBrisi.Location = new System.Drawing.Point(412, 374);
            this.btBrisi.Name = "btBrisi";
            this.btBrisi.Size = new System.Drawing.Size(341, 52);
            this.btBrisi.TabIndex = 51;
            this.btBrisi.Text = "Briši";
            this.btBrisi.UseVisualStyleBackColor = true;
            this.btBrisi.Click += new System.EventHandler(this.btBrisi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "Kupac:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Tip kartice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Poeni:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Broj kartice:";
            // 
            // dgKartice
            // 
            this.dgKartice.AllowUserToAddRows = false;
            this.dgKartice.AllowUserToDeleteRows = false;
            this.dgKartice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKartice.Location = new System.Drawing.Point(50, 72);
            this.dgKartice.MultiSelect = false;
            this.dgKartice.Name = "dgKartice";
            this.dgKartice.ReadOnly = true;
            this.dgKartice.RowHeadersVisible = false;
            this.dgKartice.RowHeadersWidth = 51;
            this.dgKartice.RowTemplate.Height = 24;
            this.dgKartice.Size = new System.Drawing.Size(703, 287);
            this.dgKartice.TabIndex = 45;
            this.dgKartice.CurrentCellChanged += new System.EventHandler(this.dgKartice_CurrentCellChanged);
            // 
            // tbBrojKartice
            // 
            this.tbBrojKartice.Location = new System.Drawing.Point(50, 44);
            this.tbBrojKartice.Name = "tbBrojKartice";
            this.tbBrojKartice.Size = new System.Drawing.Size(143, 22);
            this.tbBrojKartice.TabIndex = 53;
            // 
            // nudPoeni
            // 
            this.nudPoeni.Location = new System.Drawing.Point(254, 44);
            this.nudPoeni.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPoeni.Name = "nudPoeni";
            this.nudPoeni.Size = new System.Drawing.Size(89, 22);
            this.nudPoeni.TabIndex = 54;
            // 
            // cbTipKartice
            // 
            this.cbTipKartice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipKartice.FormattingEnabled = true;
            this.cbTipKartice.Location = new System.Drawing.Point(404, 44);
            this.cbTipKartice.Name = "cbTipKartice";
            this.cbTipKartice.Size = new System.Drawing.Size(143, 24);
            this.cbTipKartice.TabIndex = 55;
            // 
            // cbKupac
            // 
            this.cbKupac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKupac.Enabled = false;
            this.cbKupac.FormattingEnabled = true;
            this.cbKupac.Location = new System.Drawing.Point(608, 44);
            this.cbKupac.Name = "cbKupac";
            this.cbKupac.Size = new System.Drawing.Size(143, 24);
            this.cbKupac.TabIndex = 56;
            // 
            // Kartice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbKupac);
            this.Controls.Add(this.cbTipKartice);
            this.Controls.Add(this.nudPoeni);
            this.Controls.Add(this.tbBrojKartice);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btBrisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgKartice);
            this.Name = "Kartice";
            this.Text = "Kartice";
            this.Load += new System.EventHandler(this.Kartice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKartice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btBrisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgKartice;
        private System.Windows.Forms.TextBox tbBrojKartice;
        private System.Windows.Forms.NumericUpDown nudPoeni;
        private System.Windows.Forms.ComboBox cbTipKartice;
        private System.Windows.Forms.ComboBox cbKupac;
    }
}