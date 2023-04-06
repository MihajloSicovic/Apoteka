namespace Apoteka
{
    partial class Promeni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Promeni));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.tbPromena = new System.Windows.Forms.TextBox();
            this.btPotvrdi = new System.Windows.Forms.Button();
            this.btOtkrij1 = new System.Windows.Forms.Button();
            this.btOtkrij2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lozinka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(231, 73);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(178, 22);
            this.tbEmail.TabIndex = 3;
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(231, 111);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(178, 22);
            this.tbLozinka.TabIndex = 4;
            this.tbLozinka.UseSystemPasswordChar = true;
            // 
            // tbPromena
            // 
            this.tbPromena.Location = new System.Drawing.Point(231, 149);
            this.tbPromena.Name = "tbPromena";
            this.tbPromena.Size = new System.Drawing.Size(178, 22);
            this.tbPromena.TabIndex = 5;
            this.tbPromena.UseSystemPasswordChar = true;
            // 
            // btPotvrdi
            // 
            this.btPotvrdi.Location = new System.Drawing.Point(116, 190);
            this.btPotvrdi.Name = "btPotvrdi";
            this.btPotvrdi.Size = new System.Drawing.Size(293, 32);
            this.btPotvrdi.TabIndex = 6;
            this.btPotvrdi.Text = "Potrvdi";
            this.btPotvrdi.UseVisualStyleBackColor = true;
            this.btPotvrdi.Click += new System.EventHandler(this.btPotvrdi_Click);
            // 
            // btOtkrij1
            // 
            this.btOtkrij1.BackColor = System.Drawing.Color.Transparent;
            this.btOtkrij1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btOtkrij1.BackgroundImage")));
            this.btOtkrij1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btOtkrij1.FlatAppearance.BorderSize = 0;
            this.btOtkrij1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOtkrij1.ForeColor = System.Drawing.Color.Transparent;
            this.btOtkrij1.Location = new System.Drawing.Point(415, 109);
            this.btOtkrij1.Name = "btOtkrij1";
            this.btOtkrij1.Size = new System.Drawing.Size(27, 27);
            this.btOtkrij1.TabIndex = 9;
            this.btOtkrij1.UseVisualStyleBackColor = false;
            this.btOtkrij1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btOtkrij1_MouseDown);
            this.btOtkrij1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btOtkrij1_MouseUp);
            // 
            // btOtkrij2
            // 
            this.btOtkrij2.BackColor = System.Drawing.Color.Transparent;
            this.btOtkrij2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btOtkrij2.BackgroundImage")));
            this.btOtkrij2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btOtkrij2.FlatAppearance.BorderSize = 0;
            this.btOtkrij2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOtkrij2.ForeColor = System.Drawing.Color.Transparent;
            this.btOtkrij2.Location = new System.Drawing.Point(415, 149);
            this.btOtkrij2.Name = "btOtkrij2";
            this.btOtkrij2.Size = new System.Drawing.Size(27, 27);
            this.btOtkrij2.TabIndex = 10;
            this.btOtkrij2.UseVisualStyleBackColor = false;
            this.btOtkrij2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btOtkrij2_MouseDown);
            this.btOtkrij2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btOtkrij2_MouseUp);
            // 
            // Promeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 362);
            this.Controls.Add(this.btOtkrij2);
            this.Controls.Add(this.btOtkrij1);
            this.Controls.Add(this.btPotvrdi);
            this.Controls.Add(this.tbPromena);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Promeni";
            this.Text = "Promeni";
            this.Load += new System.EventHandler(this.Promeni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.TextBox tbPromena;
        private System.Windows.Forms.Button btPotvrdi;
        private System.Windows.Forms.Button btOtkrij1;
        private System.Windows.Forms.Button btOtkrij2;
    }
}