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


    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();  
            this.Hide();   
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();  
            this.Hide();   
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
