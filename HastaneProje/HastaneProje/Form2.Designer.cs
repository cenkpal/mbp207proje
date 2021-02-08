
namespace HastaneProje
{
    partial class Form2
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
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnHastaKayit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHastaGiris = new System.Windows.Forms.Button();
            this.lblFrm2Geri = new System.Windows.Forms.Label();
            this.btnHastaCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC KİMLİK NO:";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(197, 109);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(140, 22);
            this.txtTC.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(110, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ŞİFRE:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(197, 159);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(140, 22);
            this.txtSifre.TabIndex = 3;
            // 
            // btnHastaKayit
            // 
            this.btnHastaKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaKayit.Location = new System.Drawing.Point(518, 154);
            this.btnHastaKayit.Name = "btnHastaKayit";
            this.btnHastaKayit.Size = new System.Drawing.Size(115, 40);
            this.btnHastaKayit.TabIndex = 4;
            this.btnHastaKayit.Text = "Kayıt Ol";
            this.btnHastaKayit.UseVisualStyleBackColor = true;
            this.btnHastaKayit.Click += new System.EventHandler(this.btnHastaKayit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(464, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "KAYITLI DEĞİLSENİZ";
            // 
            // btnHastaGiris
            // 
            this.btnHastaGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaGiris.Location = new System.Drawing.Point(76, 223);
            this.btnHastaGiris.Name = "btnHastaGiris";
            this.btnHastaGiris.Size = new System.Drawing.Size(115, 40);
            this.btnHastaGiris.TabIndex = 7;
            this.btnHastaGiris.Text = "Giriş Yap";
            this.btnHastaGiris.UseVisualStyleBackColor = true;
            this.btnHastaGiris.Click += new System.EventHandler(this.btnHastaGiris_Click);
            // 
            // lblFrm2Geri
            // 
            this.lblFrm2Geri.AutoSize = true;
            this.lblFrm2Geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFrm2Geri.Location = new System.Drawing.Point(673, 26);
            this.lblFrm2Geri.Name = "lblFrm2Geri";
            this.lblFrm2Geri.Size = new System.Drawing.Size(76, 18);
            this.lblFrm2Geri.TabIndex = 8;
            this.lblFrm2Geri.Text = "Geri Dön";
            this.lblFrm2Geri.Click += new System.EventHandler(this.lblFrm2Geri_Click);
            // 
            // btnHastaCikis
            // 
            this.btnHastaCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaCikis.Location = new System.Drawing.Point(241, 223);
            this.btnHastaCikis.Name = "btnHastaCikis";
            this.btnHastaCikis.Size = new System.Drawing.Size(115, 40);
            this.btnHastaCikis.TabIndex = 11;
            this.btnHastaCikis.Text = "Çıkış Yap";
            this.btnHastaCikis.UseVisualStyleBackColor = true;
            this.btnHastaCikis.Click += new System.EventHandler(this.btnHastaCikis_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 315);
            this.Controls.Add(this.btnHastaCikis);
            this.Controls.Add(this.lblFrm2Geri);
            this.Controls.Add(this.btnHastaGiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHastaKayit);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Giriş/Kayıt Ekranı";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnHastaKayit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHastaGiris;
        private System.Windows.Forms.Label lblFrm2Geri;
        private System.Windows.Forms.Button btnHastaCikis;
    }
}