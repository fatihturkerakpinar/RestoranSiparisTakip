﻿namespace siparisTakip
{
    partial class FrmSepet
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
            this.dgvSepet = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMiktarArtır = new System.Windows.Forms.Button();
            this.btnMiktarAzalt = new System.Windows.Forms.Button();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSepet
            // 
            this.dgvSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSepet.Location = new System.Drawing.Point(24, 30);
            this.dgvSepet.Name = "dgvSepet";
            this.dgvSepet.RowHeadersWidth = 51;
            this.dgvSepet.RowTemplate.Height = 24;
            this.dgvSepet.Size = new System.Drawing.Size(489, 240);
            this.dgvSepet.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Siparişi Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMiktarArtır
            // 
            this.btnMiktarArtır.Location = new System.Drawing.Point(565, 159);
            this.btnMiktarArtır.Name = "btnMiktarArtır";
            this.btnMiktarArtır.Size = new System.Drawing.Size(75, 23);
            this.btnMiktarArtır.TabIndex = 2;
            this.btnMiktarArtır.Text = "+";
            this.btnMiktarArtır.UseVisualStyleBackColor = true;
            this.btnMiktarArtır.Click += new System.EventHandler(this.btnMiktarArtır_Click);
            // 
            // btnMiktarAzalt
            // 
            this.btnMiktarAzalt.Location = new System.Drawing.Point(565, 217);
            this.btnMiktarAzalt.Name = "btnMiktarAzalt";
            this.btnMiktarAzalt.Size = new System.Drawing.Size(75, 23);
            this.btnMiktarAzalt.TabIndex = 3;
            this.btnMiktarAzalt.Text = "-";
            this.btnMiktarAzalt.UseVisualStyleBackColor = true;
            this.btnMiktarAzalt.Click += new System.EventHandler(this.btnMiktarAzalt_Click);
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(565, 351);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(44, 16);
            this.lblToplamTutar.TabIndex = 4;
            this.lblToplamTutar.Text = "label1";
            // 
            // FrmSepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.btnMiktarAzalt);
            this.Controls.Add(this.btnMiktarArtır);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSepet);
            this.Name = "FrmSepet";
            this.Text = "FrmSepet";
            this.Load += new System.EventHandler(this.FrmSepet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSepet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMiktarArtır;
        private System.Windows.Forms.Button btnMiktarAzalt;
        private System.Windows.Forms.Label lblToplamTutar;
    }
}