using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace OtobusFirması
{
    public partial class Otobuskayit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\ASUS\Documents\Visual Studio 2013\Projects\OtobusFirması\OtobusFirması\bin\Debug\Otobus.mdf';Integrated Security=True");
        OtobusEntities db = new OtobusEntities();
        public Otobuskayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            StreamReader sr = new StreamReader("a.txt", Encoding.Default);

            while (!sr.EndOfStream)
            {

                string satir = sr.ReadLine();
                SqlCommand komut = new SqlCommand("insert into Sehirler(SehirAdi) values(@sehir)", con);
                komut.Parameters.AddWithValue("sehir", satir);
                komut.ExecuteNonQuery();
            }
            sr.Close();
            con.Close();
        }
    }
}
