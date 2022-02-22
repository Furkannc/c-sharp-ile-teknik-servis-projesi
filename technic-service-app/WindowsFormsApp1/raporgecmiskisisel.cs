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
    public partial class raporgecmiskisisel : Form
    {
        public raporgecmiskisisel()
        {
            InitializeComponent();
        }
        bgsınıf bg=new bgsınıf();
        public string id;
        private void raporgecmiskisisel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("select rapor_konu,rapor_aciklama,rapor_tarih,rapor_cozum,rapor_cevap from tbl_rapor where kul_id=" + id, bg.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
