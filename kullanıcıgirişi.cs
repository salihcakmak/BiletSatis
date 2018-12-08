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
    public partial class kullanıcıgirişi : Form
    {
        public kullanıcıgirişi()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\ASUS\Documents\Visual Studio 2013\Projects\OtobusFirması\OtobusFirması\bin\Debug\Otobus.mdf';Integrated Security=True");

       

        private void kullanıcıgirişi_Load(object sender, EventArgs e)
        {
            
        }

        private void kullanıcıgirişi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select Username,Password from Login where Username=@name and Password=@pas", baglantı);
            komut.Parameters.AddWithValue("name", textBox1.Text);

            komut.Parameters.AddWithValue("pas", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifrenizi kontrol ediniz");
            }
            baglantı.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

      


        private void label5_Click(object sender, EventArgs e)
        {
            kullanıcıkayıt kyt = new kullanıcıkayıt();
            kyt.Show();
            this.Hide();
        }

        private void kullanıcıgirişi_KeyDown(object sender, KeyEventArgs e)
        {
           
         }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {



                baglantı.Open();
                SqlCommand komut = new SqlCommand("select * from Login where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", baglantı);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lütfen Kullanıcı Adı ve Şifrenizi kontrol ediniz");
                }
                baglantı.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kullanıcıkayıt kyt = new kullanıcıkayıt();
            kyt.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kayıtsorgu frm = new kayıtsorgu();
            frm.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
