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
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-55VPBP0Q\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");

        bool durum;
        void tekrarKayit()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM hasta WHERE hastaTCNO=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTC.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                durum = false;

            }
            else
            {
                durum = true;
            }
            baglanti.Close();
        }

        private void btnHastaGonder_Click(object sender, EventArgs e)
        {
            if (txtTC.Text == "")
            {

                MessageBox.Show("TC NO BOŞ OLAMAZ");

                return;
            }

            if (txtAd.Text == "")
            {

                MessageBox.Show("AD BOŞ OLAMAZ");

                return;

            }
            if (txtSoyad.Text == "")
            {

                MessageBox.Show("SOYAD BOŞ OLAMAZ");

                return;
            }

            if (txtCins.Text == "")
            {

                MessageBox.Show("CİNSİYET BOŞ OLAMAZ");

                return;

            }
            if (txtCep.Text == "")
            {

                MessageBox.Show("CEP NO BOŞ OLAMAZ");

                return;
            }

            if (txtSifre.Text == "")
            {

                MessageBox.Show("ŞİFRE BOŞ OLAMAZ");

                return;

            }
            if (txtAdres.Text == "")
            {

                MessageBox.Show("ADRES BOŞ OLAMAZ");

                return;
            }

            tekrarKayit();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO hasta (hastaTCNO,hastaAD,hastaSOYAD,hastaCINSIYET,hastaSIFRE,hastaCEPTEL,hastaADRES)" +
                    " values (@tc,@ad,@soyad,@cinsiyet,@sifre,@ceptel,@adres)", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@cinsiyet", txtCins.Text);
                komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
                komut.Parameters.AddWithValue("@ceptel", txtCep.Text);
                komut.Parameters.AddWithValue("@adres", txtAdres.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kaydınız Oluşturuldu.");
            }
            else
            {
                MessageBox.Show("Bu TC No'ya Ait Kayıt Vardır..", "Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                   
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void lblFrm4Geri_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           

        }

        private void btnHastaTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtAdres.Clear();
            txtCep.Clear();
            txtCins.Clear();
            txtSifre.Clear();
            txtSoyad.Clear();
            txtTC.Clear();
        }
    }
}
