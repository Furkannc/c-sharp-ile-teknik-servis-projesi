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
    public partial class yoneticipanel : Form
    {
        bgsınıf bg = new bgsınıf();
        public yoneticipanel()
        {
            InitializeComponent();
        }
        public string ad, id, perid, perad, persoyad, pertc, persifre, kulid, kulad, kulsoyad, kuldep, kultc, kulsifre;

        private void btnraporla_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into tbl_rapor (rapor_konu,rapor_aciklama,rapor_tarih,yonetici_id,rapor_cozum) values (@p1,@p2,@p3,@p4,@p5)", bg.baglanti());
            kmt.Parameters.AddWithValue("@p1", txtkonu.Text);
            kmt.Parameters.AddWithValue("@p2", rchtxtaciklama.Text);
            kmt.Parameters.AddWithValue("@p3", dtptarih.Text);
            kmt.Parameters.AddWithValue("@p4", id);
            kmt.Parameters.AddWithValue("@p5", "0");
            kmt.ExecuteNonQuery();
            bg.baglanti().Close();
            MessageBox.Show("Rapor başarıyla iletildi.");
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            yoneticigirispnl ygp = new yoneticigirispnl(); this.Close(); ygp.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            deplist dl = new deplist(); dl.Show();
        }
        private void btnkullaniciguncelle_Click(object sender, EventArgs e)
        {
            int sayi = cmb_dep.SelectedIndex + 1;
            SqlCommand cmd = new SqlCommand("update tbl_kul set kul_ad=@p1,kul_soyad=@p2,kul_departman=@p3,kul_tc=@p4,kul_sifre=@p5 where kul_id=@p6", bg.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtkulad.Text);
            cmd.Parameters.AddWithValue("@p2", txtkulsoyad.Text);
            cmd.Parameters.AddWithValue("@p3", sayi);
            cmd.Parameters.AddWithValue("@p4", txtkultc.Text);
            cmd.Parameters.AddWithValue("@p5", txtkulsifre.Text);
            cmd.Parameters.AddWithValue("@p6", txtkulid.Text);
            if (MessageBox.Show(txtkulad.Text + "  Adlı kullanıcıyı güncellemek istediğinize emin misiniz", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı başarıyla güncellendi!");
            }
            bg.baglanti().Close();
        }
        private void btnkullaniciekle_Click(object sender, EventArgs e)
        {
            int sayi = cmb_dep.SelectedIndex + 1;
            SqlCommand cmd = new SqlCommand("insert into tbl_kul (kul_ad,kul_soyad,dep_id,kul_tc,kul_sifre) values (@p1,@p2,@p3,@p4,@p5)", bg.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtkulad.Text);
            cmd.Parameters.AddWithValue("@p2", txtkulsoyad.Text);
            cmd.Parameters.AddWithValue("@p3", sayi);
            cmd.Parameters.AddWithValue("@p4", txtkultc.Text);
            cmd.Parameters.AddWithValue("@p5", txtkulsifre.Text);
            cmd.ExecuteNonQuery();
            bg.baglanti().Close();
            MessageBox.Show("Kullanıcı Kayıt edildi.");
        }
        private void btnperguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update tbl_per set per_ad=@p1,per_soyad=@p2,per_tc=@p3,per_sifre=@p4 where per_id=@p5", bg.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtperad.Text);
            cmd.Parameters.AddWithValue("@p2", txtpersoyad.Text);
            cmd.Parameters.AddWithValue("@p3", txtpertc.Text);
            cmd.Parameters.AddWithValue("@p4", txtpersifre.Text);
            cmd.Parameters.AddWithValue("@p5", txtperid.Text);
            if (MessageBox.Show(txtperad.Text + "  Adlı personeli guncellemek istediğinize emin misiniz", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Personel başarıyla güncellendi!");
            }
            bg.baglanti().Close();
        }
        private void btnperekle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_per (per_ad,per_soyad,per_tc,per_sifre) values (@p1,@p2,@p3,@p4)", bg.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtperad.Text);
            cmd.Parameters.AddWithValue("@p2", txtpersoyad.Text);
            cmd.Parameters.AddWithValue("@p3", txtpertc.Text);
            cmd.Parameters.AddWithValue("@p4", txtpersifre.Text);
            cmd.ExecuteNonQuery();
            bg.baglanti().Close();
            MessageBox.Show("Personel Kayıt edildi.");
        }
        private void btnyoneticiolus_Click(object sender, EventArgs e)
        {
            yoneticilist yl = new yoneticilist();
            yl.Show();
        }

        private void btnkullanicilist_Click(object sender, EventArgs e)
        {
            kullanicilist kl = new kullanicilist();
            kl.Show();
            this.Hide();
        }

        private void btnpersonellist_Click(object sender, EventArgs e)
        {
            personellist pl = new personellist();
            pl.Show();
            this.Hide();
        }

        private void btngecmis_Click(object sender, EventArgs e)
        {
            gecmissorunsikayet gss = new gecmissorunsikayet();
            gss.Show();
        }

        private void yoneticipanel_Load(object sender, EventArgs e)
        {
            lblid.Text = id;
            lblad.Text = ad;
            txtperid.Text = perid;
            txtperad.Text = perad;
            txtpersoyad.Text = persoyad;
            txtpertc.Text = pertc;
            txtpersifre.Text = persifre;
            txtkulad.Text = kulad;
            txtkulid.Text = kulid;
            txtkulsoyad.Text = kulsoyad;
            txtkultc.Text = kultc;
            txtkulsifre.Text = kulsifre;
            SqlCommand sc = new SqlCommand("select dep_ad from tbl_dep ", bg.baglanti());
            SqlDataReader dr = sc.ExecuteReader();
            while (dr.Read())
            {
                cmb_dep.Items.Add(dr[0]);
            }
            bg.baglanti().Close();
        }
    }
}
