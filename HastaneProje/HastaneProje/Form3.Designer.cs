
namespace HastaneProje
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDktrID = new System.Windows.Forms.TextBox();
            this.txtDktrSıfre = new System.Windows.Forms.TextBox();
            this.btnDoktorGiris = new System.Windows.Forms.Button();
            this.lblFrm3Geri = new System.Windows.Forms.Label();
            this.btnDktrCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOKTOR ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(94, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ŞİFRE:";
            // 
            // txtDktrID
            // 
            this.txtDktrID.Location = new System.Drawing.Point(194, 99);
            this.txtDktrID.MaxLength = 11;
            this.txtDktrID.Name = "txtDktrID";
            this.txtDktrID.Size = new System.Drawing.Size(133, 22);
            this.txtDktrID.TabIndex = 3;
            // 
            // txtDktrSıfre
            // 
            this.txtDktrSıfre.Location = new System.Drawing.Point(194, 151);
            this.txtDktrSıfre.Name = "txtDktrSıfre";
            this.txtDktrSıfre.PasswordChar = '*';
            this.txtDktrSıfre.Size = new System.Drawing.Size(133, 22);
            this.txtDktrSıfre.TabIndex = 4;
            // 
            // btnDoktorGiris
            // 
            this.btnDoktorGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorGiris.Location = new System.Drawing.Point(89, 230);
            this.btnDoktorGiris.Name = "btnDoktorGiris";
            this.btnDoktorGiris.Size = new System.Drawing.Size(115, 40);
            this.btnDoktorGiris.TabIndex = 8;
            this.btnDoktorGiris.Text = "Giriş Yap";
            this.btnDoktorGiris.UseVisualStyleBackColor = true;
            this.btnDoktorGiris.Click += new System.EventHandler(this.btnDoktorGiris_Click);
            // 
            // lblFrm3Geri
            // 
            this.lblFrm3Geri.AutoSize = true;
            this.lblFrm3Geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFrm3Geri.Location = new System.Drawing.Point(312, 27);
            this.lblFrm3Geri.Name = "lblFrm3Geri";
            this.lblFrm3Geri.Size = new System.Drawing.Size(76, 18);
            this.lblFrm3Geri.TabIndex = 9;
            this.lblFrm3Geri.Text = "Geri Dön";
            this.lblFrm3Geri.Click += new System.EventHandler(this.lblFrm3Geri_Click);
            // 
            // btnDktrCikis
            // 
            this.btnDktrCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDktrCikis.Location = new System.Drawing.Point(230, 230);
            this.btnDktrCikis.Name = "btnDktrCikis";
            this.btnDktrCikis.Size = new System.Drawing.Size(115, 40);
            this.btnDktrCikis.TabIndex = 10;
            this.btnDktrCikis.Text = "Çıkış Yap";
            this.btnDktrCikis.UseVisualStyleBackColor = true;
            this.btnDktrCikis.Click += new System.EventHandler(this.btnDktrCikis_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 334);
            this.Controls.Add(this.btnDktrCikis);
            this.Controls.Add(this.lblFrm3Geri);
            this.Controls.Add(this.btnDoktorGiris);
            this.Controls.Add(this.txtDktrSıfre);
            this.Controls.Add(this.txtDktrID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = "Doktor Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDktrID;
        private System.Windows.Forms.TextBox txtDktrSıfre;
        private System.Windows.Forms.Button btnDoktorGiris;
        private System.Windows.Forms.Label lblFrm3Geri;
        private System.Windows.Forms.Button btnDktrCikis;
    }
}