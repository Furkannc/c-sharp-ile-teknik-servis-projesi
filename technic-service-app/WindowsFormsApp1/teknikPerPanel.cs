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
    public partial class teknikPerPanel : Form
    {
        public teknikPerPanel()
        {
            InitializeComponent();
        }
        bgsınıf bg = new bgsınıf();
        public string id;
        public string ad;
        void yenile()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select r.rapor_id,r.rapor_konu,r.rapor_aciklama,r.rapor_tarih,r.rapor_cozum" +
                ",k.kul_ad,k.kul_soyad,r.yonetici_id from tbl_rapor r inner join tbl_kul k on k.kul_id=r.kul_id where rapor_cozum=0", bg.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void teknikPerPanel_Load(object sender, EventArgs e)
        {
            lbltc.Text = id;
            yenile();
            lblad.Text = ad;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            txtkonu.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            lbltarih.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();

            if (dataGridView1.Rows[sec].Cells[4].Value.ToString() == "False")
            {
                radioButton2.Checked = true;
            }
        }
        private void btngecmis_Click(object sender, EventArgs e)
        {
            gecmissorunsikayet gss = new gecmissorunsikayet();
            gss.Show();
        }
        private void btnkydt_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update tbl_rapor set rapor_cozum=@p1,per_id=@p2,rapor_cevap=@p3,rapor_cozum_tarih=@p4 where rapor_id=@p5", bg.baglanti());
            if (radioButton1.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p1", "1");
            }
            else
            {
                cmd.Parameters.AddWithValue("@p1", "0");
            }
            cmd.Parameters.AddWithValue("@p2", id);
            cmd.Parameters.AddWithValue("@p3", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@p4", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@p5", txtid.Text);
            if (MessageBox.Show(txtkonu.Text + " Adlı raporu güncellemek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rapor Güncellendi!");
            }
            bg.baglanti().Close();
            yenile();
        }
        private void btngeri_Click(object sender, EventArgs e)
        {
            teknikpergiris tpg = new teknikpergiris(); this.Close(); tpg.Show();
        }
    }
}
