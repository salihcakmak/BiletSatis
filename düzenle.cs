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
    public partial class düzenle : Form
    {
        public int id;
        OtobusEntities db = new OtobusEntities();
        public düzenle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calisanlar düzelt = (from x in db.Calisanlars
                                 where x.PersonelID == id
                                 select x).FirstOrDefault();

            düzelt.Ad = textBox1.Text;
            düzelt.Soyad = textBox2.Text;
            düzelt.Email = textBox3.Text;
            düzelt.Telefon = Convert.ToDecimal(textBox4.Text);
            if (radioButton1.Checked == true)
            {


                düzelt.CalisanTipID = 1;
            }
            else { düzelt.CalisanTipID = 2; }
            db.SaveChanges();
         
            this.Close();
        }

        private void düzenle_Load(object sender, EventArgs e)
        {
            Calisanlar düzelt = (from x in db.Calisanlars
                                 where x.PersonelID == id
                                 select x).FirstOrDefault();
            textBox1.Text = düzelt.Ad;
            textBox2.Text = düzelt.Soyad;
            textBox3.Text = düzelt.Email;
            textBox4.Text = düzelt.Telefon.ToString();
            if (düzelt.CalisanTipID == 1)
            {
                radioButton1.Checked = true;
            }
            else { radioButton2.Checked = true; }
        }

        private void düzenle_FormClosing(object sender, FormClosingEventArgs e)
        {
            görüntüle frm = new görüntüle();
            frm.Show();
        }
    }
}
