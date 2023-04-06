namespace Apoteka
{
    partial class Ulogovanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ulogovanje));
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.btNazad = new System.Windows.Forms.Button();
            this.btZaposleni = new System.Windows.Forms.Button();
            this.btPotvrdi = new System.Windows.Forms.Button();
            this.btKupac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btOtkrij = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.llbNapraviNalog = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(366, 99);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(164, 22);
            this.tbEmail.TabIndex = 0;
            this.tbEmail.Visible = false;
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(366, 139);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(164, 22);
            this.tbLozinka.TabIndex = 1;
            this.tbLozinka.UseSystemPasswordChar = true;
            this.tbLozinka.Visible = false;
            // 
            // btNazad
            // 
            this.btNazad.Location = new System.Drawing.Point(12, 12);
            this.btNazad.Name = "btNazad";
            this.btNazad.Size = new System.Drawing.Size(75, 54);
            this.btNazad.TabIndex = 2;
            this.btNazad.Text = "<-----";
            this.btNazad.UseVisualStyleBackColor = true;
            this.btNazad.Visible = false;
            this.btNazad.Click += new System.EventHandler(this.btNazad_Click);
            // 
            // btZaposleni
            // 
            this.btZaposleni.Location = new System.Drawing.Point(100, 296);
            this.btZaposleni.Name = "btZaposleni";
            this.btZaposleni.Size = new System.Drawing.Size(157, 88);
            this.btZaposleni.TabIndex = 3;
            this.btZaposleni.Tag = "zaposleni";
            this.btZaposleni.Text = "Strana\r\nzaposleni\r\n<----";
            this.btZaposleni.UseVisualStyleBackColor = true;
            this.btZaposleni.Click += new System.EventHandler(this.btStrana_Click);
            // 
            // btPotvrdi
            // 
            this.btPotvrdi.Location = new System.Drawing.Point(272, 191);
            this.btPotvrdi.Name = "btPotvrdi";
            this.btPotvrdi.Size = new System.Drawing.Size(258, 32);
            this.btPotvrdi.TabIndex = 4;
            this.btPotvrdi.Text = "Prijavite se";
            this.btPotvrdi.UseVisualStyleBackColor = true;
            this.btPotvrdi.Visible = false;
            this.btPotvrdi.Click += new System.EventHandler(this.btPotvrdi_Click);
            // 
            // btKupac
            // 
            this.btKupac.Location = new System.Drawing.Point(547, 296);
            this.btKupac.Name = "btKupac";
            this.btKupac.Size = new System.Drawing.Size(157, 88);
            this.btKupac.TabIndex = 5;
            this.btKupac.Tag = "kupac";
            this.btKupac.Text = "Strana\r\nkupac\r\n---->";
            this.btKupac.UseVisualStyleBackColor = true;
            this.btKupac.Click += new System.EventHandler(this.btStrana_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lozinka:";
            this.label2.Visible = false;
            // 
            // btOtkrij
            // 
            this.btOtkrij.BackColor = System.Drawing.Color.Transparent;
            this.btOtkrij.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btOtkrij.BackgroundImage")));
            this.btOtkrij.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btOtkrij.FlatAppearance.BorderSize = 0;
            this.btOtkrij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOtkrij.ForeColor = System.Drawing.Color.Transparent;
            this.btOtkrij.Location = new System.Drawing.Point(536, 137);
            this.btOtkrij.Name = "btOtkrij";
            this.btOtkrij.Size = new System.Drawing.Size(27, 27);
            this.btOtkrij.TabIndex = 8;
            this.btOtkrij.UseVisualStyleBackColor = false;
            this.btOtkrij.Visible = false;
            this.btOtkrij.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btOtkrij_MouseDown);
            this.btOtkrij.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btOtkrij_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nemate nalog?";
            this.label3.Visible = false;
            // 
            // llbNapraviNalog
            // 
            this.llbNapraviNalog.AutoSize = true;
            this.llbNapraviNalog.Location = new System.Drawing.Point(404, 242);
            this.llbNapraviNalog.Name = "llbNapraviNalog";
            this.llbNapraviNalog.Size = new System.Drawing.Size(106, 16);
            this.llbNapraviNalog.TabIndex = 10;
            this.llbNapraviNalog.TabStop = true;
            this.llbNapraviNalog.Text = "Napravite nalog.";
            this.llbNapraviNalog.Visible = false;
            this.llbNapraviNalog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.llbNapraviNalog_MouseClick);
            // 
            // Ulogovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llbNapraviNalog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btOtkrij);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btKupac);
            this.Controls.Add(this.btPotvrdi);
            this.Controls.Add(this.btZaposleni);
            this.Controls.Add(this.btNazad);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.tbEmail);
            this.Name = "Ulogovanje";
            this.Text = "Apoteka";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ulogovanje_FormClosing);
            this.Load += new System.EventHandler(this.Ulogovanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Button btNazad;
        private System.Windows.Forms.Button btZaposleni;
        private System.Windows.Forms.Button btPotvrdi;
        private System.Windows.Forms.Button btKupac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOtkrij;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llbNapraviNalog;
    }
}

