using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusFirması
{
    public partial class SehirlerKayit : Form
    {
        public SehirlerKayit()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection baglantı = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\ASUS\documents\visual studio 2013\Projects\OtobusFirması\OtobusFirması\Otobus.mdf';Integrated Security=True");
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into sehirler(sehirAdi) values(@sadi)",baglantı);
            komut.Parameters.AddWithValue("sadi",textBox1.Text);
            int sayı = komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show(sayı + " adet kayıt EKLENDİ");
          

        }

        private void SehirlerKayit_Load(object sender, EventArgs e)
        {
            SqlConnection baglantı = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\ASUS\documents\visual studio 2013\Projects\OtobusFirması\OtobusFirması\Otobus.mdf';Integrated Security=True");
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from Sehirler", baglantı);
            SqlDataReader okunan = komut.ExecuteReader();
            while (okunan.Read())
            {
                listBox1.Items.Add(okunan["SehirID"] + " " + okunan["SehirAdi"]);
            }
            baglantı.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection baglantı = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\ASUS\documents\visual studio 2013\Projects\OtobusFirması\OtobusFirması\Otobus.mdf';Integrated Security=True");
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from Sehirler", baglantı);
            SqlDataReader okunan = komut.ExecuteReader();
            while (okunan.Read())
            {
                listBox1.Items.Add(okunan["SehirID"] + " " + okunan["SehirAdi"]);
            }
            baglantı.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            string alınan = listBox1.SelectedItem.ToString();
            string[] dizi = alınan.Split();
            int id = Convert.ToInt32(dizi[0]);
            SqlConnection baglantı = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\ASUS\documents\visual studio 2013\Projects\OtobusFirması\OtobusFirması\Otobus.mdf';Integrated Security=True");
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update sehirler set SehirAdi=@sadi where SehirID = @sid",baglantı);
            komut.Parameters.AddWithValue("sadi",textBox1.Text);
            komut.Parameters.AddWithValue("sid", id);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show(id + "ıncı kayıt güncellendi");


            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string alınan = listBox1.SelectedItem.ToString();
            string[] dizi = alınan.Split();
            int id = Convert.ToInt32(dizi[0]);
            SqlConnection baglantı = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\ASUS\documents\visual studio 2013\Projects\OtobusFirması\OtobusFirması\Otobus.mdf';Integrated Security=True");
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from Sehirler where SehirID=@sid", baglantı);
          
            komut.Parameters.AddWithValue("sid", id);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show(id + "ıncı kayıt silindi");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string alınan = listBox1.SelectedItem.ToString();
            string[] dizi = alınan.Split();
            int id = Convert.ToInt32(dizi[0]);
            SqlConnection baglantı = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\ASUS\documents\visual studio 2013\Projects\OtobusFirması\OtobusFirması\Otobus.mdf';Integrated Security=True");
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update sehirler set SehirAdi=Upper(SehirAdi) where SehirID = @sid", baglantı);
                        komut.Parameters.AddWithValue("sid", id);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show(id + "ıncı kayıt güncellendi");
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string alınan = listBox1.SelectedItem.ToString();
            string[] dizi = alınan.Split();
            int id = Convert.ToInt32(dizi[0]);
            SqlConnection baglantı = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\ASUS\documents\visual studio 2013\Projects\OtobusFirması\OtobusFirması\Otobus.mdf';Integrated Security=True");
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update sehirler set SehirAdi=Lower(SehirAdi) where SehirID = @sid", baglantı);
            komut.Parameters.AddWithValue("sid", id);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show(id + "ıncı kayıt güncellendi");
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
