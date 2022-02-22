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
    public partial class gecmissorunsikayet : Form
    {
        public gecmissorunsikayet()
        {
            InitializeComponent();
        }
        bgsınıf bg = new bgsınıf();
        private void gecmissorunsikayet_Load(object sender, EventArgs e)
        {
            yenile();
        }
        void yenile()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select k.kul_ad,k.kul_soyad,r.*,p.per_ad,p.per_soyad from " +
                "tbl_rapor r inner join tbl_kul k on k.kul_id=r.kul_id inner join tbl_per p on p.per_id=r.per_id where rapor_cozum=1", bg.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnvarsayılan_Click(object sender, EventArgs e)
        {
            yenile();
        }
        private void btntrh_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_rapor where rapor_tarih='" + dateTimePicker1.Value.ToString("dd.MM.yyyy") + "'", bg.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnkulidgore_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_rapor where kul_id=" + txtid.Text, bg.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnyoneticiidgore_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_rapor where yonetici_id=" + txtyonid.Text, bg.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnkonugore_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_rapor where rapor_konu='" + txtkonu.Text + "'", bg.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnraporsil_Click(object sender, EventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            SqlCommand sqc = new SqlCommand("delete from tbl_rapor where per_id=@p1", bg.baglanti());
            sqc.Parameters.AddWithValue("@p1", dataGridView1.Rows[sec].Cells[0].Value.ToString());
            if (MessageBox.Show(dataGridView1.Rows[sec].Cells[1].Value.ToString() +
                "  Konulu raporu silmek istediğinize emin misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sqc.ExecuteNonQuery();
                yenile();
            }
        }
        private void btnperidgore_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_rapor where per_id=" + perid.Text, bg.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
