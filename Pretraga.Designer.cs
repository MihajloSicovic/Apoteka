namespace Apoteka
{
    partial class Pretraga
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pretraga));
            this.dgPretraga = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPretraga = new System.Windows.Forms.TextBox();
            this.btPretrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPretraga)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPretraga
            // 
            this.dgPretraga.AllowUserToAddRows = false;
            this.dgPretraga.AllowUserToDeleteRows = false;
            this.dgPretraga.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPretraga.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgPretraga.Location = new System.Drawing.Point(84, 137);
            this.dgPretraga.MultiSelect = false;
            this.dgPretraga.Name = "dgPretraga";
            this.dgPretraga.ReadOnly = true;
            this.dgPretraga.RowHeadersVisible = false;
            this.dgPretraga.RowHeadersWidth = 51;
            this.dgPretraga.RowTemplate.Height = 24;
            this.dgPretraga.Size = new System.Drawing.Size(634, 287);
            this.dgPretraga.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lokal:";
            // 
            // tbPretraga
            // 
            this.tbPretraga.Location = new System.Drawing.Point(145, 103);
            this.tbPretraga.Name = "tbPretraga";
            this.tbPretraga.Size = new System.Drawing.Size(133, 22);
            this.tbPretraga.TabIndex = 2;
            // 
            // btPretrazi
            // 
            this.btPretrazi.BackColor = System.Drawing.Color.Transparent;
            this.btPretrazi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPretrazi.BackgroundImage")));
            this.btPretrazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPretrazi.Location = new System.Drawing.Point(284, 101);
            this.btPretrazi.Name = "btPretrazi";
            this.btPretrazi.Size = new System.Drawing.Size(27, 27);
            this.btPretrazi.TabIndex = 3;
            this.btPretrazi.UseVisualStyleBackColor = false;
            this.btPretrazi.Click += new System.EventHandler(this.btPretrazi_Click);
            // 
            // Pretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPretrazi);
            this.Controls.Add(this.tbPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPretraga);
            this.Name = "Pretraga";
            this.Text = "Pretraga";
            this.Load += new System.EventHandler(this.Pretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPretraga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPretraga;
        private System.Windows.Forms.Button btPretrazi;
    }
}