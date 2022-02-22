using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
namespace WindowsFormsApp1
{
    class bgsınıf
    {
        public SqlConnection baglanti()
        {
            string adres = System.IO.File.ReadAllText(@"E:\baglanti.txt");
            SqlConnection bgl = new SqlConnection(adres);
            bgl.Open();
            return bgl;
        }
    }
}
