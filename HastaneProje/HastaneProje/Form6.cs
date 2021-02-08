using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneProje
{
    public partial class Form6 : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-55VPBP0Q\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
        SqlCommand komut = new SqlCommand();

        public string yazi;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            lblTcnoyaz.Text = yazi;

            cmbPoliklinik.Items.Clear();
            SqlDataReader dr;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM pol";
            dr = komut.ExecuteReader();
                  
            while (dr.Read())
            {
                cmbPoliklinik.Items.Add(dr[1].ToString());
            }
            baglanti.Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
                    


            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO randevu (randevuTARIH,randevuSAAT,hastaTCNO,doktorAD,doktorSOYAD,poliklinikAD)" +
                " values (@randevuTARIH,@randevuSAAT,@hastaTCNO,@doktorAD,@doktorSOYAD,@poliklinikAD)", baglanti);
          

            komut.Parameters.AddWithValue("@randevuTARIH", dtpTarih.Value.ToString());
            komut.Parameters.AddWithValue("@randevuSAAT", cmbSaat.Text.ToString());
            komut.Parameters.AddWithValue("@hastaTCNO", lblTcnoyaz.Text.ToString());
            komut.Parameters.AddWithValue("@doktorAD", txtDoktorAd.Text.ToString());
            komut.Parameters.AddWithValue("@doktorSOYAD", txtDoktorSoyad.Text.ToString());
            komut.Parameters.AddWithValue("@poliklinikAD", cmbPoliklinik.Text.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();


            MessageBox.Show("RANDEVUNUZ BAŞARILI BİR ŞEKİLDE ALINMIŞTIR.");

            

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void lblFrm6Geri_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
       
        private void btnGetir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM pol WHERE poliklinikAD like '" + cmbPoliklinik.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtDoktorAd.Text= read["doktorAD"].ToString();
                txtDoktorSoyad.Text = read["doktorSOYAD"].ToString();
            }
            baglanti.Close();
        }
    }
}
