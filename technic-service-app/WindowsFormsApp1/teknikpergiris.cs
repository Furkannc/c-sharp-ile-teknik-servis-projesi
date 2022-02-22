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
    public partial class teknikpergiris : Form
    {
        public teknikpergiris()
        {
            InitializeComponent();
        }
        private void teknikpergiris_Load(object sender, EventArgs e)
        {
            lbltrh.Text = DateTime.Now.ToLongDateString();
        }
        bgsınıf bg = new bgsınıf();
        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tbl_per where per_tc=@p1 and per_sifre=@p2", bg.baglanti());
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                teknikPerPanel tpp = new teknikPerPanel();
                tpp.ad = dr[1].ToString();

                tpp.id = dr[0].ToString();
                tpp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC no veya şifre!");
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
