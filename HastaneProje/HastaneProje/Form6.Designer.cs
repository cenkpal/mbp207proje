
namespace HastaneProje
{
    partial class Form6
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPoliklinik = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.lblFrm6Geri = new System.Windows.Forms.Label();
            this.txtDoktorAd = new System.Windows.Forms.TextBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.txtDoktorSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTcnoyaz = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(81, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "POLİKLİNİK:";
            // 
            // cmbPoliklinik
            // 
            this.cmbPoliklinik.FormattingEnabled = true;
            this.cmbPoliklinik.Location = new System.Drawing.Point(228, 92);
            this.cmbPoliklinik.Name = "cmbPoliklinik";
            this.cmbPoliklinik.Size = new System.Drawing.Size(191, 24);
            this.cmbPoliklinik.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "DOKTOR AD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "RANDEVU TARİHİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "RANDEVU SAATİ:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(207, 373);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(128, 47);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbSaat
            // 
            this.cmbSaat.FormattingEnabled = true;
            this.cmbSaat.Items.AddRange(new object[] {
            "08.00",
            "09.00",
            "10.00",
            "11.00",
            "12.00",
            "13.00",
            "14.00",
            "15.00",
            "16.00",
            "17.00"});
            this.cmbSaat.Location = new System.Drawing.Point(228, 294);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(191, 24);
            this.cmbSaat.TabIndex = 14;
            // 
            // lblFrm6Geri
            // 
            this.lblFrm6Geri.AutoSize = true;
            this.lblFrm6Geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFrm6Geri.Location = new System.Drawing.Point(469, 22);
            this.lblFrm6Geri.Name = "lblFrm6Geri";
            this.lblFrm6Geri.Size = new System.Drawing.Size(76, 18);
            this.lblFrm6Geri.TabIndex = 27;
            this.lblFrm6Geri.Text = "Geri Dön";
            this.lblFrm6Geri.Click += new System.EventHandler(this.lblFrm6Geri_Click);
            // 
            // txtDoktorAd
            // 
            this.txtDoktorAd.Location = new System.Drawing.Point(228, 149);
            this.txtDoktorAd.Name = "txtDoktorAd";
            this.txtDoktorAd.Size = new System.Drawing.Size(191, 22);
            this.txtDoktorAd.TabIndex = 30;
            // 
            // btnGetir
            // 
            this.btnGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.Location = new System.Drawing.Point(442, 107);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(114, 42);
            this.btnGetir.TabIndex = 31;
            this.btnGetir.Text = "İsim Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // txtDoktorSoyad
            // 
            this.txtDoktorSoyad.Location = new System.Drawing.Point(228, 195);
            this.txtDoktorSoyad.Name = "txtDoktorSoyad";
            this.txtDoktorSoyad.Size = new System.Drawing.Size(191, 22);
            this.txtDoktorSoyad.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "DOKTOR SOYAD:";
            // 
            // lblTcnoyaz
            // 
            this.lblTcnoyaz.AutoSize = true;
            this.lblTcnoyaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcnoyaz.Location = new System.Drawing.Point(126, 9);
            this.lblTcnoyaz.Name = "lblTcnoyaz";
            this.lblTcnoyaz.Size = new System.Drawing.Size(118, 18);
            this.lblTcnoyaz.TabIndex = 34;
            this.lblTcnoyaz.Text = "TC KİMLİK NO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "TC KİMLİK NO:";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(228, 241);
            this.dtpTarih.MaxDate = new System.DateTime(2021, 3, 8, 0, 0, 0, 0);
            this.dtpTarih.MinDate = new System.DateTime(2021, 2, 8, 0, 0, 0, 0);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(191, 22);
            this.dtpTarih.TabIndex = 37;
            this.dtpTarih.Value = new System.DateTime(2021, 2, 8, 0, 0, 0, 0);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 460);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTcnoyaz);
            this.Controls.Add(this.txtDoktorSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.txtDoktorAd);
            this.Controls.Add(this.lblFrm6Geri);
            this.Controls.Add(this.cmbSaat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPoliklinik);
            this.Controls.Add(this.label2);
            this.Name = "Form6";
            this.ShowIcon = false;
            this.Text = "Randevu Alma Ekranı";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPoliklinik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.Label lblFrm6Geri;
        private System.Windows.Forms.TextBox txtDoktorAd;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.TextBox txtDoktorSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTcnoyaz;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker dtpTarih;
    }
}