namespace Apoteka
{
    partial class NovZaposleni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovZaposleni));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.cbMenadzer = new System.Windows.Forms.ComboBox();
            this.cbUloga = new System.Windows.Forms.ComboBox();
            this.cbLokal = new System.Windows.Forms.ComboBox();
            this.btPotvrdi = new System.Windows.Forms.Button();
            this.btOtkrij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lozinka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Menadžer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Uloga:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lokal:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(187, 49);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(154, 22);
            this.tbEmail.TabIndex = 5;
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(187, 108);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(154, 22);
            this.tbLozinka.TabIndex = 6;
            this.tbLozinka.UseSystemPasswordChar = true;
            // 
            // cbMenadzer
            // 
            this.cbMenadzer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenadzer.FormattingEnabled = true;
            this.cbMenadzer.Location = new System.Drawing.Point(187, 167);
            this.cbMenadzer.Name = "cbMenadzer";
            this.cbMenadzer.Size = new System.Drawing.Size(154, 24);
            this.cbMenadzer.TabIndex = 7;
            this.cbMenadzer.SelectedValueChanged += new System.EventHandler(this.cbMenadzer_SelectedValueChanged);
            // 
            // cbUloga
            // 
            this.cbUloga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUloga.FormattingEnabled = true;
            this.cbUloga.Location = new System.Drawing.Point(187, 228);
            this.cbUloga.Name = "cbUloga";
            this.cbUloga.Size = new System.Drawing.Size(154, 24);
            this.cbUloga.TabIndex = 8;
            // 
            // cbLokal
            // 
            this.cbLokal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLokal.FormattingEnabled = true;
            this.cbLokal.Location = new System.Drawing.Point(187, 289);
            this.cbLokal.Name = "cbLokal";
            this.cbLokal.Size = new System.Drawing.Size(154, 24);
            this.cbLokal.TabIndex = 9;
            // 
            // btPotvrdi
            // 
            this.btPotvrdi.Location = new System.Drawing.Point(105, 347);
            this.btPotvrdi.Name = "btPotvrdi";
            this.btPotvrdi.Size = new System.Drawing.Size(236, 42);
            this.btPotvrdi.TabIndex = 10;
            this.btPotvrdi.Text = "Potvrdi";
            this.btPotvrdi.UseVisualStyleBackColor = true;
            this.btPotvrdi.Click += new System.EventHandler(this.btPotvrdi_Click);
            // 
            // btOtkrij
            // 
            this.btOtkrij.BackColor = System.Drawing.Color.Transparent;
            this.btOtkrij.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btOtkrij.BackgroundImage")));
            this.btOtkrij.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btOtkrij.FlatAppearance.BorderSize = 0;
            this.btOtkrij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOtkrij.ForeColor = System.Drawing.Color.Transparent;
            this.btOtkrij.Location = new System.Drawing.Point(347, 106);
            this.btOtkrij.Name = "btOtkrij";
            this.btOtkrij.Size = new System.Drawing.Size(27, 27);
            this.btOtkrij.TabIndex = 11;
            this.btOtkrij.UseVisualStyleBackColor = false;
            this.btOtkrij.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btOtkrij_MouseDown);
            this.btOtkrij.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btOtkrij_MouseUp);
            // 
            // NovZaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.btOtkrij);
            this.Controls.Add(this.btPotvrdi);
            this.Controls.Add(this.cbLokal);
            this.Controls.Add(this.cbUloga);
            this.Controls.Add(this.cbMenadzer);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NovZaposleni";
            this.Text = "NovZaposleni";
            this.Load += new System.EventHandler(this.NovZaposleni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.ComboBox cbMenadzer;
        private System.Windows.Forms.ComboBox cbUloga;
        private System.Windows.Forms.ComboBox cbLokal;
        private System.Windows.Forms.Button btPotvrdi;
        private System.Windows.Forms.Button btOtkrij;
    }
}