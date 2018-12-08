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

namespace OtobusFirması
{
    public partial class kullanıcıkayıt : Form
    {
        public kullanıcıkayıt()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\ASUS\Documents\Visual Studio 2013\Projects\OtobusFirması\OtobusFirması\bin\Debug\Otobus.mdf';Integrated Security=True");

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBox3.TextLength == 4)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBox4.TextLength == 4)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            { MessageBox.Show("Lütfen Boş Alanları Doldurunuz."); }

            else if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("PİN ler aynı değil.");
            }
            else if (textBox6.Text != textBox7.Text)
            {
                MessageBox.Show("Şifreler aynı değil.");
            }
            else if (textBox3.TextLength !=4)
            {
                MessageBox.Show("Lütfen PİN'i 4 rakam giriniz.");
            }
            else
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into Login(Username,Password,Adı,Soyadı,PIN)  values(@username,@password,@adi,@soyadi,@pin)", baglantı);
                komut.Parameters.AddWithValue("username", textBox5.Text);
                komut.Parameters.AddWithValue("password", textBox6.Text);
                komut.Parameters.AddWithValue("adi", textBox1.Text);
                komut.Parameters.AddWithValue("soyadi", textBox2.Text);
                komut.Parameters.AddWithValue("pin", textBox3.Text);
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Kayıt Başarılı");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox1.Focus();
            }

        }

        private void kullanıcıkayıt_FormClosing(object sender, FormClosingEventArgs e)
        {
            kullanıcıgirişi frm = new kullanıcıgirişi();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kullanıcıkayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
