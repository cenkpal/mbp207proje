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
    public partial class Form5 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-55VPBP0Q\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");

       
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        SqlCommandBuilder cmdb;
        public string dktr;
        public Form5()
        {
            InitializeComponent();
        }

        private void lblFrm5Geri_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
        void KayıtSil(int Randevu)
        {
            string sql = "DELETE FROM randevu WHERE randevuID=@randevuID";
            komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@randevuID", Randevu);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void Form5_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            da = new SqlDataAdapter("Select randevuID,hastaTCNO,doktorAD,doktorSOYAD,poliklinikAD,randevuTARIH,randevuSAAT from randevu", baglanti);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "randevu");
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }



        private void lblCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                int Randevu = Convert.ToInt32(drow.Cells[0].Value);
                KayıtSil(Randevu);
                MessageBox.Show("KAYITLAR SİLİNDİ.");
            }
        }

        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {
            da.Update(ds, "randevu");
            MessageBox.Show("KAYITLAR GÜNCELLENDİ.");
        }
    }
}
