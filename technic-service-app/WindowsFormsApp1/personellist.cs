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
    public partial class personellist : Form
    {
        public personellist()
        {
            InitializeComponent();
        }
        bgsınıf bg = new bgsınıf();
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            yoneticipanel yp = new yoneticipanel();
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            yp.perid = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            yp.perad = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            yp.persoyad = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            yp.pertc = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            yp.persifre = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            yp.Show();
            this.Hide();
        }
        private void personellist_FormClosed(object sender, FormClosedEventArgs e)
        {
            yoneticipanel yp = new yoneticipanel();
            yp.Show();
        }
        private void personellist_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_per", bg.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            SqlCommand sqc = new SqlCommand("delete from tbl_per where per_id=@p1", bg.baglanti());
            sqc.Parameters.AddWithValue("@p1", dataGridView1.Rows[sec].Cells[0].Value.ToString());
            if (MessageBox.Show(dataGridView1.Rows[sec].Cells[1].Value.ToString() + "  Adlı personeli silmek istediğinize emin misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sqc.ExecuteNonQuery();

            }
            bg.baglanti().Close();
        }
    }
}
