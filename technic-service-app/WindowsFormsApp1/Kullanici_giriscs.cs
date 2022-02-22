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

namespace WindowsFormsApp1
{
    public partial class Kullanici_giriscs : Form
    {
        public Kullanici_giriscs()
        {
            InitializeComponent();
        }
        private void Kullanici_giriscs_Load(object sender, EventArgs e)
        {
            lbltarih.Text = DateTime.Now.ToLongDateString();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            kullanicipanel pp = new kullanicipanel();
            bgsınıf bg = new bgsınıf();
            SqlCommand cm = new SqlCommand("select * from tbl_kul where kul_tc=@p1 and kul_sifre=@p2", bg.baglanti());
            cm.Parameters.AddWithValue("@p1", textBox1.Text);
            cm.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {

                pp.ad = dr[1].ToString();

                pp.id = dr[0].ToString();

                pp.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Tc kimlik numarası veya sifre yanlıs!!");
            }
            bg.baglanti().Close();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            girisPanel gp = new girisPanel();
            this.Close(); gp.Show();
        }
    }
}
