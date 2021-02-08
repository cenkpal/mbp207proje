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
    public partial class Form3 : Form
    {
        
        SqlCommand cmd;
        SqlDataReader dr;

      
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            if (txtDktrID.Text == "")
            {

                MessageBox.Show("DOKTOR ID BOŞ OLAMAZ");

                return;
            }

            if (txtDktrSıfre.Text == "")
            {

                MessageBox.Show("ŞİFRE BOŞ OLAMAZ");

                return;

            }

            string doktorID = txtDktrID.Text;
            string doktorSifre = txtDktrSıfre.Text;
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-55VPBP0Q\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            cmd = new SqlCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT * FROM doktor WHERE doktorID='" + txtDktrID.Text + "' AND doktorSifre='" + txtDktrSıfre.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Başarılı bir şekilde giriş yaptınız.");
                Form5 form5 = new Form5();
                form5.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız veya şifreniz hatalı.");
            }
            baglanti.Close();


        }

        private void lblFrm3Geri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnDktrCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
