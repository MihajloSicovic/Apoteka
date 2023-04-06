namespace Apoteka
{
    partial class Dostave
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
            this.btOdlozi = new System.Windows.Forms.Button();
            this.btPrimi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDostave = new System.Windows.Forms.DataGridView();
            this.dtpDatumIsporuke = new System.Windows.Forms.DateTimePicker();
            this.btBrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDostave)).BeginInit();
            this.SuspendLayout();
            // 
            // btOdlozi
            // 
            this.btOdlozi.Location = new System.Drawing.Point(50, 374);
            this.btOdlozi.Name = "btOdlozi";
            this.btOdlozi.Size = new System.Drawing.Size(200, 52);
            this.btOdlozi.TabIndex = 61;
            this.btOdlozi.Text = "Odložite dostavu";
            this.btOdlozi.UseVisualStyleBackColor = true;
            this.btOdlozi.Click += new System.EventHandler(this.btOdlozi_Click);
            // 
            // btPrimi
            // 
            this.btPrimi.Location = new System.Drawing.Point(560, 374);
            this.btPrimi.Name = "btPrimi";
            this.btPrimi.Size = new System.Drawing.Size(192, 52);
            this.btPrimi.TabIndex = 60;
            this.btPrimi.Text = "Primite isporučene dostave";
            this.btPrimi.UseVisualStyleBackColor = true;
            this.btPrimi.Click += new System.EventHandler(this.btPrimi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "Datum isporuke:";
            // 
            // dgDostave
            // 
            this.dgDostave.AllowUserToAddRows = false;
            this.dgDostave.AllowUserToDeleteRows = false;
            this.dgDostave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDostave.Location = new System.Drawing.Point(50, 72);
            this.dgDostave.MultiSelect = false;
            this.dgDostave.Name = "dgDostave";
            this.dgDostave.ReadOnly = true;
            this.dgDostave.RowHeadersVisible = false;
            this.dgDostave.RowHeadersWidth = 51;
            this.dgDostave.RowTemplate.Height = 24;
            this.dgDostave.Size = new System.Drawing.Size(703, 287);
            this.dgDostave.TabIndex = 56;
            this.dgDostave.CurrentCellChanged += new System.EventHandler(this.dgDostave_CurrentCellChanged);
            // 
            // dtpDatumIsporuke
            // 
            this.dtpDatumIsporuke.Location = new System.Drawing.Point(50, 44);
            this.dtpDatumIsporuke.Name = "dtpDatumIsporuke";
            this.dtpDatumIsporuke.Size = new System.Drawing.Size(200, 22);
            this.dtpDatumIsporuke.TabIndex = 62;
            // 
            // btBrisi
            // 
            this.btBrisi.Location = new System.Drawing.Point(309, 374);
            this.btBrisi.Name = "btBrisi";
            this.btBrisi.Size = new System.Drawing.Size(192, 52);
            this.btBrisi.TabIndex = 63;
            this.btBrisi.Text = "Otkažite dostavu";
            this.btBrisi.UseVisualStyleBackColor = true;
            this.btBrisi.Click += new System.EventHandler(this.btBrisi_Click);
            // 
            // Dostave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBrisi);
            this.Controls.Add(this.dtpDatumIsporuke);
            this.Controls.Add(this.btOdlozi);
            this.Controls.Add(this.btPrimi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDostave);
            this.Name = "Dostave";
            this.Text = "Dostave";
            this.Load += new System.EventHandler(this.Dostave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDostave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btOdlozi;
        private System.Windows.Forms.Button btPrimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDostave;
        private System.Windows.Forms.DateTimePicker dtpDatumIsporuke;
        private System.Windows.Forms.Button btBrisi;
    }
}