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
    public partial class görüntüle : Form
    {
        OtobusEntities db = new OtobusEntities();

        public görüntüle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.SelectedIndex != -1)
            {


                decimal tel = Convert.ToDecimal(textBox2.Text);
                var kaynak = (from x in db.Calisanlars
                              where x.Ad == textBox1.Text && x.Telefon == tel  && x.CalisanTipID == (int)comboBox1.SelectedValue
                              select new { ID = x.PersonelID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, İŞİ = x.CalisanTipleri.CalisanTipAdi }).ToList();
                             
                dataGridView1.DataSource = kaynak;
            }
            if (textBox2.Text != "" && comboBox1.SelectedIndex != -1)
            {


                decimal tel = Convert.ToDecimal(textBox2.Text);
                var kaynak = (from x in db.Calisanlars
                              where x.Telefon == tel && x.CalisanTipID == (int)comboBox1.SelectedValue
                              select new { ID = x.PersonelID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, İŞİ = x.CalisanTipleri.CalisanTipAdi }).ToList();

                dataGridView1.DataSource = kaynak;
            }
            if (textBox1.Text != "" && comboBox1.SelectedIndex != -1)
            {


              
                var kaynak = (from x in db.Calisanlars
                              where x.Ad == textBox1.Text && x.CalisanTipID == (int)comboBox1.SelectedValue
                              select new { ID = x.PersonelID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, İŞİ = x.CalisanTipleri.CalisanTipAdi }).ToList();

                dataGridView1.DataSource = kaynak;
            }
            else if (textBox1.Text != "" && textBox2.Text != "" )
            {


                decimal tel = Convert.ToDecimal(textBox2.Text);
                var kaynak = (from x in db.Calisanlars
                              where x.Ad == textBox1.Text && x.Telefon == tel
                              select new { ID = x.PersonelID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, İŞİ = x.CalisanTipleri.CalisanTipAdi }).ToList();
                             
                dataGridView1.DataSource = kaynak;
            }
            else if (textBox1.Text != "" )
            {

                var kaynak = (from x in db.Calisanlars
                              where x.Ad == textBox1.Text 
                              select new { ID = x.PersonelID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, İŞİ = x.CalisanTipleri.CalisanTipAdi }).ToList();

                dataGridView1.DataSource = kaynak;
            }
            else if (textBox2.Text != "")
            {
                decimal tel = Convert.ToDecimal(textBox2.Text);
                var kaynak = (from x in db.Calisanlars
                              where x.Telefon == tel
                              select new { ID = x.PersonelID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, İŞİ = x.CalisanTipleri.CalisanTipAdi }).ToList();

                dataGridView1.DataSource = kaynak;
            }
            else if (comboBox1.SelectedIndex != -1)
            {

                var kaynak = (from x in db.Calisanlars
                              where x.CalisanTipID ==(int)comboBox1.SelectedValue 
                              select new { ID = x.PersonelID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, İŞİ = x.CalisanTipleri.CalisanTipAdi }).ToList();

                dataGridView1.DataSource = kaynak;
            }
            else
            {
                var kaynak = (from x in db.Calisanlars
                              select new { ID = x.PersonelID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, İŞİ = x.CalisanTipleri.CalisanTipAdi }).ToList();
                dataGridView1.DataSource = kaynak;
            }
            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void görüntüle_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dataSet1.CalisanTipleri' table. You can move, or remove it, as needed.
            this.calisanTipleriTableAdapter.Fill(this.dataSet1.CalisanTipleri);

        }

        private void görüntüle_Shown(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz");
            }
            else
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                düzenle frm = new düzenle();
                frm.id = id;
                frm.Show();
                this.Hide();
            }
        }

        private void görüntüle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            
        }
    }
}
