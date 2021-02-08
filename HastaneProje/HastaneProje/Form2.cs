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
    public partial class Form2 : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
       
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            if (txtTC.Text == "")
            {
                MessageBox.Show("TC NO BOŞ OLAMAZ");
                return;
            }
            if (txtSifre.Text == "")
            {
                MessageBox.Show("ŞİFRE BOŞ OLAMAZ");
                return;
            }         
            string hastaTCNO = txtTC.Text;
            string hastaSIFRE = txtSifre.Text;
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-55VPBP0Q\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            cmd = new SqlCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT * FROM hasta WHERE hastaTCNO='" + txtTC.Text + "' AND hastaSIFRE='" + txtSifre.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Başarılı bir şekilde giriş yaptınız.");
                Form6 form6 = new Form6();
                form6.yazi = txtTC.Text;
                form6.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adınız veya şifreniz hatalı.");
            }           
            baglanti.Close();        
        }

        private void btnHastaKayit_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show(); 
            this.Hide();   
        }

        private void lblFrm2Geri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnHastaCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
