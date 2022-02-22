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
    public partial class yoneticilist : Form
    {
        public yoneticilist()
        {
            InitializeComponent();
        }
        bgsınıf bg = new bgsınıf();
        void yenile()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_yonetici", bg.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void yoneticilist_Load(object sender, EventArgs e)
        {
            yenile();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_yonetici (yonetici_ad,yonetici_soyad,yonetici_tc,yonetici_sifre) values (@p1,@p2,@p3,@p4)", bg.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtad.Text);
            cmd.Parameters.AddWithValue("@p2", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@p3", txttc.Text);
            cmd.Parameters.AddWithValue("@p4", txtsifre.Text);
            cmd.ExecuteNonQuery();
            bg.baglanti().Close();
            MessageBox.Show("Yönetici eklendi");
            yenile();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update tbl_yonetici set yonetici_ad=@p1,yonetici_soyad=@p2,yonetici_tc=@p3,yonetici_sifre=@p4 where yonetici_id=@p5", bg.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtad.Text);
            cmd.Parameters.AddWithValue("@p2", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@p3", txttc.Text);
            cmd.Parameters.AddWithValue("@p4", txtsifre.Text);
            cmd.Parameters.AddWithValue("@p5", txtid.Text);
            if (MessageBox.Show(txtad.Text + " Adlı yöneticiyi güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(txtad.Text + " Adlı yönetici güncellendi");
            }
            bg.baglanti().Close();
            yenile();
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from tbl_yonetici where yonetici_id=@p1", bg.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtid.Text);
            if (MessageBox.Show(txtad.Text + " Adlı yönetici silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(txtad.Text + " Yönetici silindi");
            }
            bg.baglanti().Close();
            yenile();
        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int sec = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            txttc.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
        }
    }
}
