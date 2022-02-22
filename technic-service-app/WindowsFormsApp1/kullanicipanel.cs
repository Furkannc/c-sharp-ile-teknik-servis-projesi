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
    public partial class kullanicipanel : Form
    {
        public kullanicipanel()
        {
            InitializeComponent();
        }
        public string id,ad;
        bgsınıf bg = new bgsınıf();
        void temizle()
        {
            txtkonu.Text = "";
            rchtxtack.Text = "";
        }
        private void btngonder_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into tbl_rapor (rapor_konu,rapor_aciklama,rapor_tarih,kul_id,rapor_cozum) values (@p1,@p2,@p3,@p4,@p5)", bg.baglanti());
            kmt.Parameters.AddWithValue("@p1", txtkonu.Text);
            kmt.Parameters.AddWithValue("@p2", rchtxtack.Text);
            kmt.Parameters.AddWithValue("@p3", dateTimePicker1.Text);
            kmt.Parameters.AddWithValue("@p4", id);
            kmt.Parameters.AddWithValue("@p5", "0");
            kmt.ExecuteNonQuery();
            bg.baglanti().Close();
            MessageBox.Show("Rapor iletildi.");
            temizle();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            Kullanici_giriscs kg = new Kullanici_giriscs(); this.Close(); kg.Show();
        }

        private void btngecmis_Click(object sender, EventArgs e)
        {
            raporgecmiskisisel rgk = new raporgecmiskisisel();
            rgk.id = idlbl.Text;
            rgk.Show();
        }
        private void kullanicipanel_Load(object sender, EventArgs e)
        {
            lblad.Text=ad;
            idlbl.Text = id;
        }
    }
}
