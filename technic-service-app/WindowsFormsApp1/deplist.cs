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
    public partial class deplist : Form
    {
        public deplist()
        {
            InitializeComponent();
        }
        bgsınıf bg = new bgsınıf();
        
        private void deplist_Load(object sender, EventArgs e)
        {
            yenile();
            ///////////////////////////////////////////////////////////////////////////////
            SqlCommand sq = new SqlCommand("select * from tbl_yonetici", bg.baglanti());
            SqlDataReader dr = sq.ExecuteReader();
            while(dr.Read())
            {
                cmbyonet.Items.Add(dr[0] + "  " + dr[1] + " " + dr[2]);
            }
            bg.baglanti().Close();
        }
        void yenile()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_dep", bg.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            int sayı = cmbyonet.SelectedIndex + 1;
            SqlCommand cm = new SqlCommand("insert into tbl_dep (dep_ad,yonetici_id) values (@p1,@p2)", bg.baglanti());
            cm.Parameters.AddWithValue("@p1", txtad.Text);
            cm.Parameters.AddWithValue("@p2", sayı);
            if (MessageBox.Show(txtad.Text + " Adlı departmanı eklemek istediğinize eminmisiniz? ", "Eklensin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cm.ExecuteNonQuery();
                MessageBox.Show("Kayıt eklendi!");
            }
            bg.baglanti().Close();
            yenile();
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int sayı = cmbyonet.SelectedIndex + 1;
            SqlCommand s = new SqlCommand("update tbl_dep set dep_ad=@p1,yonetici_id=@p2 where dep_id=@p3", bg.baglanti());
            s.Parameters.AddWithValue("@p1", txtad.Text);
            s.Parameters.AddWithValue("@p2", sayı);
            s.Parameters.AddWithValue("@p3", txtid.Text);
            if (MessageBox.Show(txtad.Text + "  Adlı departmanı guncellemek istediğinize emin misiniz", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                s.ExecuteNonQuery();
                MessageBox.Show("Kayıt güncellendi!");
            }
            bg.baglanti().Close();
            yenile();
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand sq = new SqlCommand("delete from tbl_dep where dep_id=@p1", bg.baglanti());
            sq.Parameters.AddWithValue("@p1", txtid.Text);
            if (MessageBox.Show(txtad.Text + " Adlı departmanı silmek istediğinize emin misiniz?", "Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sq.ExecuteNonQuery();
                MessageBox.Show("Kayıt silindi! ");
            }
            bg.baglanti().Close();
            yenile();
        }
    }
}
