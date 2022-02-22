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
    public partial class yoneticigirispnl : Form
    {
        public yoneticigirispnl()
        {
            InitializeComponent();
        }
        bgsınıf bg = new bgsınıf();
        private void yoneticigirispnl_Load(object sender, EventArgs e)
        {
            lbltarih.Text = DateTime.Now.ToLongDateString();
        }
        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tbl_yonetici where yonetici_tc=@p1 and yonetici_sifre=@p2", bg.baglanti());
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                yoneticipanel yp = new yoneticipanel();
                yp.ad = dr[1].ToString();
                yp.id = dr[0].ToString();
                yp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Yönetici Tc veya Şifre!");
            }
        }
        private void btngeri_Click(object sender, EventArgs e)
        {
            girisPanel gp = new girisPanel();
            this.Close(); gp.Show();
        }
    }
}
