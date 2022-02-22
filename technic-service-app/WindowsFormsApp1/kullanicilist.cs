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
    public partial class kullanicilist : Form
    {
        public kullanicilist()
        {
            InitializeComponent();
        }
        bgsınıf bg = new bgsınıf();
        private void kullanicilist_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_kul", bg.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            SqlCommand sqc = new SqlCommand("delete from tbl_kul where kul_id=@p1", bg.baglanti());
            sqc.Parameters.AddWithValue("@p1", dataGridView1.Rows[sec].Cells[0].Value.ToString());
            if (MessageBox.Show(dataGridView1.Rows[sec].Cells[1].Value.ToString() + "  Adlı kullanıcıyı silmek istediğinize emin misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sqc.ExecuteNonQuery();
            }
            bg.baglanti().Close();
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            yoneticipanel yp = new yoneticipanel();
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            yp.kulid = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            yp.kulad = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            yp.kulsoyad = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            yp.kuldep = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            yp.kultc = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            yp.kulsifre = dataGridView1.Rows[sec].Cells[5].Value.ToString();
            yp.Show();
            this.Hide();
        }
        private void kullanicilist_FormClosed(object sender, FormClosedEventArgs e)
        {
            yoneticipanel yp = new yoneticipanel();
            yp.Show();
        }
    }
}
