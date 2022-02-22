using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class girisPanel : Form
    {
        public girisPanel()
        {
            InitializeComponent();
        }
        private void btnkullanici_Click(object sender, EventArgs e)
        {
            Kullanici_giriscs gir = new Kullanici_giriscs();
            gir.Show();
            this.Hide();
        }
        private void btnpersonel_Click(object sender, EventArgs e)
        {
            teknikpergiris tp = new teknikpergiris();
            tp.Show();
            this.Hide();
        }
        private void btnyonetici_Click(object sender, EventArgs e)
        {
            yoneticigirispnl gir = new yoneticigirispnl();
            gir.Show();
            this.Hide();
        }
    }
}
