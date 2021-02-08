
namespace HastaneProje
{
    partial class Form5
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
            this.lblFrm5Geri = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCikis = new System.Windows.Forms.Label();
            this.btnKayitSil = new System.Windows.Forms.Button();
            this.btnKayitGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrm5Geri
            // 
            this.lblFrm5Geri.AutoSize = true;
            this.lblFrm5Geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFrm5Geri.Location = new System.Drawing.Point(683, 21);
            this.lblFrm5Geri.Name = "lblFrm5Geri";
            this.lblFrm5Geri.Size = new System.Drawing.Size(76, 18);
            this.lblFrm5Geri.TabIndex = 28;
            this.lblFrm5Geri.Text = "Geri Dön";
            this.lblFrm5Geri.Click += new System.EventHandler(this.lblFrm5Geri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(825, 380);
            this.dataGridView1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Randevular";
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikis.Location = new System.Drawing.Point(790, 21);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(79, 18);
            this.lblCikis.TabIndex = 32;
            this.lblCikis.Text = "Çıkış Yap";
            this.lblCikis.Click += new System.EventHandler(this.lblCikis_Click);
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitSil.Location = new System.Drawing.Point(253, 476);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(158, 32);
            this.btnKayitSil.TabIndex = 33;
            this.btnKayitSil.Text = "KAYIT SİL";
            this.btnKayitSil.UseVisualStyleBackColor = true;
            this.btnKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            // 
            // btnKayitGuncelle
            // 
            this.btnKayitGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitGuncelle.Location = new System.Drawing.Point(511, 476);
            this.btnKayitGuncelle.Name = "btnKayitGuncelle";
            this.btnKayitGuncelle.Size = new System.Drawing.Size(158, 32);
            this.btnKayitGuncelle.TabIndex = 34;
            this.btnKayitGuncelle.Text = "KAYIT GÜNCELLE";
            this.btnKayitGuncelle.UseVisualStyleBackColor = true;
            this.btnKayitGuncelle.Click += new System.EventHandler(this.btnKayitGuncelle_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 535);
            this.Controls.Add(this.btnKayitGuncelle);
            this.Controls.Add(this.btnKayitSil);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblFrm5Geri);
            this.Name = "Form5";
            this.ShowIcon = false;
            this.Text = "Randevuların Ekranı";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrm5Geri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Button btnKayitSil;
        private System.Windows.Forms.Button btnKayitGuncelle;
    }
}