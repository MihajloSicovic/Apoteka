namespace Apoteka
{
    partial class PregledZaposleni
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
            this.cbUloga = new System.Windows.Forms.ComboBox();
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btBrisi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgZaposleni = new System.Windows.Forms.DataGridView();
            this.cbLokal = new System.Windows.Forms.ComboBox();
            this.cbMenadzer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgZaposleni)).BeginInit();
            this.SuspendLayout();
            // 
            // cbUloga
            // 
            this.cbUloga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUloga.FormattingEnabled = true;
            this.cbUloga.Location = new System.Drawing.Point(549, 44);
            this.cbUloga.Name = "cbUloga";
            this.cbUloga.Size = new System.Drawing.Size(204, 24);
            this.cbUloga.TabIndex = 44;
            // 
            // btIzmeni
            // 
            this.btIzmeni.Location = new System.Drawing.Point(50, 374);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(339, 52);
            this.btIzmeni.TabIndex = 39;
            this.btIzmeni.Text = "Izmeni";
            this.btIzmeni.UseVisualStyleBackColor = true;
            this.btIzmeni.Click += new System.EventHandler(this.btIzmeni_Click);
            // 
            // btBrisi
            // 
            this.btBrisi.Location = new System.Drawing.Point(412, 374);
            this.btBrisi.Name = "btBrisi";
            this.btBrisi.Size = new System.Drawing.Size(341, 52);
            this.btBrisi.TabIndex = 38;
            this.btBrisi.Text = "Briši";
            this.btBrisi.UseVisualStyleBackColor = true;
            this.btBrisi.Click += new System.EventHandler(this.btBrisi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Menadžer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Radno mesto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Uloga:";
            // 
            // dgZaposleni
            // 
            this.dgZaposleni.AllowUserToAddRows = false;
            this.dgZaposleni.AllowUserToDeleteRows = false;
            this.dgZaposleni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgZaposleni.Location = new System.Drawing.Point(50, 72);
            this.dgZaposleni.MultiSelect = false;
            this.dgZaposleni.Name = "dgZaposleni";
            this.dgZaposleni.ReadOnly = true;
            this.dgZaposleni.RowHeadersVisible = false;
            this.dgZaposleni.RowHeadersWidth = 51;
            this.dgZaposleni.RowTemplate.Height = 24;
            this.dgZaposleni.Size = new System.Drawing.Size(703, 287);
            this.dgZaposleni.TabIndex = 32;
            this.dgZaposleni.CurrentCellChanged += new System.EventHandler(this.dgZaposleni_CurrentCellChanged);
            // 
            // cbLokal
            // 
            this.cbLokal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLokal.FormattingEnabled = true;
            this.cbLokal.Location = new System.Drawing.Point(50, 44);
            this.cbLokal.Name = "cbLokal";
            this.cbLokal.Size = new System.Drawing.Size(204, 24);
            this.cbLokal.TabIndex = 45;
            // 
            // cbMenadzer
            // 
            this.cbMenadzer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenadzer.FormattingEnabled = true;
            this.cbMenadzer.Location = new System.Drawing.Point(299, 44);
            this.cbMenadzer.Name = "cbMenadzer";
            this.cbMenadzer.Size = new System.Drawing.Size(204, 24);
            this.cbMenadzer.TabIndex = 46;
            this.cbMenadzer.SelectedValueChanged += new System.EventHandler(this.cbMenadzer_SelectedValueChanged);
            // 
            // PregledZaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbMenadzer);
            this.Controls.Add(this.cbLokal);
            this.Controls.Add(this.cbUloga);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btBrisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgZaposleni);
            this.Name = "PregledZaposleni";
            this.Text = "PregledZaposleni";
            this.Load += new System.EventHandler(this.PregledZaposleni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgZaposleni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUloga;
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btBrisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgZaposleni;
        private System.Windows.Forms.ComboBox cbLokal;
        private System.Windows.Forms.ComboBox cbMenadzer;
    }
}