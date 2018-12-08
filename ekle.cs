using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusFirması
{
    public partial class ekle : Form
    {
        OtobusEntities db = new OtobusEntities();
        public ekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")

            { MessageBox.Show("Lütfen Boş Alanları Doldurunuz."); }
            else
            {
                Calisanlar r = new Calisanlar();
                r.Ad = textBox1.Text;
                r.Soyad = textBox2.Text;
                r.Email = textBox3.Text;
                r.Telefon = Convert.ToInt64(textBox4.Text);
                if (radioButton1.Checked == true)
                {
                    r.CalisanTipID =1;
                }
                else
                {
                    r.CalisanTipID = 2;
                }
               db.Calisanlars.Add(r);
                db.SaveChanges();


                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
               
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBox4.TextLength == 11)
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

        private void ekle_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void ekle_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void ekle_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
