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
    public partial class müşterigörüntüle : Form
    {
        OtobusEntities db = new OtobusEntities();
        public müşterigörüntüle()
        {
            InitializeComponent();
        }

        private void müşterigörüntüle_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dataSet1.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter.Fill(this.dataSet1.Musteriler);
            // TODO: This line of code loads data into the 'dataSet1.Sehirler' table. You can move, or remove it, as needed.
            this.sehirlerTableAdapter.Fill(this.dataSet1.Sehirler);
            comboBox2.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string s = comboBox1.SelectedItem.ToString();
            //MessageBox.Show(s);
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {


                decimal tel = Convert.ToDecimal(textBox2.Text);
                var kaynak = (from x in db.Musterilers
                              where x.Ad == textBox1.Text && x.Telefon == tel && x.SehirID == (int)comboBox2.SelectedValue && x.Cinsiyet == comboBox1.SelectedItem.ToString()
                              select new { ID = x.MusteriID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, x.Cinsiyet, Şehir = x.Sehirler.SehirAdi }).ToList();
                dataGridView1.DataSource = kaynak;
            }
           else if (textBox2.Text != "" && comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {


                decimal tel = Convert.ToDecimal(textBox2.Text);
                var kaynak = (from x in db.Musterilers
                              where x.Telefon == tel && x.SehirID == (int)comboBox2.SelectedValue && x.Cinsiyet == comboBox1.SelectedItem.ToString()
                              select new { ID = x.MusteriID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, x.Cinsiyet, Şehir = x.Sehirler.SehirAdi }).ToList();
                dataGridView1.DataSource = kaynak;
            }
            else if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {              
                var kaynak = (from x in db.Musterilers
                              where x.SehirID == (int)comboBox2.SelectedValue && x.Cinsiyet == comboBox1.SelectedItem.ToString()
                              select new { ID = x.MusteriID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, x.Cinsiyet, Şehir = x.Sehirler.SehirAdi }).ToList();
                dataGridView1.DataSource = kaynak;
            }
           
            else if (textBox1.Text != "" && textBox2.Text != "" && comboBox2.SelectedIndex != -1)
            {



                decimal tel = Convert.ToDecimal(textBox2.Text);
                var kaynak = (from x in db.Musterilers
                              where x.Ad == textBox1.Text && x.Telefon == tel && x.SehirID == (int)comboBox2.SelectedValue
                              select new { ID = x.MusteriID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, x.Cinsiyet, Şehir = x.Sehirler.SehirAdi }).ToList();
                dataGridView1.DataSource = kaynak;
            }
            else if (textBox1.Text != "" && textBox2.Text != "")
            {




                decimal tel = Convert.ToDecimal(textBox2.Text);
                var kaynak = (from x in db.Musterilers
                              where x.Ad == textBox1.Text && x.Telefon == tel
                              select new { ID = x.MusteriID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, x.Cinsiyet, Şehir = x.Sehirler.SehirAdi }).ToList();
                dataGridView1.DataSource = kaynak;
            }
            else if (textBox2.Text != "" && comboBox1.SelectedIndex != -1)
            {
                decimal tel = Convert.ToDecimal(textBox2.Text);


                var kaynak = (from x in db.Musterilers
                              where x.Telefon == tel && x.Cinsiyet == comboBox1.SelectedItem.ToString()
                              select new { ID = x.MusteriID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, x.Cinsiyet, Şehir = x.Sehirler.SehirAdi }).ToList();
                dataGridView1.DataSource = kaynak;
            }

            else if (textBox2.Text != "" && comboBox2.SelectedIndex != -1)
            {

                decimal tel = Convert.ToDecimal(textBox2.Text);

                var kaynak = (from x in db.Musterilers
                              where x.Telefon == tel && x.SehirID == (int)comboBox2.SelectedValue
                              select new { ID = x.MusteriID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, x.Cinsiyet, Şehir = x.Sehirler.SehirAdi }).ToList();
                dataGridView1.DataSource = kaynak;
            }

            else if (textBox1.Text != "" && comboBox1.SelectedIndex != -1)
            {



                var kaynak = (from x in db.Musterilers
                              where x.Ad == textBox1.Text && x.Cinsiyet == comboBox1.SelectedItem.ToString()
                              select new { ID = x.MusteriID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, x.Cinsiyet, Şehir = x.Sehirler.SehirAdi }).ToList();
                dataGridView1.DataSource = kaynak;
            }
          
            else if (textBox1.Text!="" && comboBox2.SelectedIndex != -1)
            {



                var kaynak = (from x in db.Musterilers
                              where x.Ad == textBox1.Text && x.SehirID == (int)comboBox2.SelectedValue
                              select new { ID = x.MusteriID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, x.Cinsiyet, Şehir = x.Sehirler.SehirAdi }).ToList();
                dataGridView1.DataSource = kaynak;
            }
            else if (textBox1.Text != "")
            {



                var kaynak = (from x in db.Musterilers
                              where x.Ad == textBox1.Text
                              select new { ID = x.MusteriID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, x.Cinsiyet, Şehir = x.Sehirler.SehirAdi }).ToList();
                dataGridView1.DataSource = kaynak;
            }
            else if (textBox2.Text != "")
            {
                decimal tel = Convert.ToDecimal(textBox2.Text);


                var kaynak = (from x in db.Musterilers
                              where x.Telefon == tel
                              select new { ID = x.MusteriID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, x.Cinsiyet, Şehir = x.Sehirler.SehirAdi }).ToList();
                dataGridView1.DataSource = kaynak;
            }
            else if (comboBox1.SelectedIndex != -1)
            {



                var kaynak = (from x in db.Musterilers
                              where x.Cinsiyet == comboBox1.SelectedItem.ToString()
                              select new { ID = x.MusteriID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, x.Cinsiyet, Şehir = x.Sehirler.SehirAdi }).ToList();
                dataGridView1.DataSource = kaynak;
            }
            else if (comboBox2.SelectedIndex != -1)
            {



                var kaynak = (from x in db.Musterilers
                              where x.SehirID == (int)comboBox2.SelectedValue
                              select new { ID = x.MusteriID, Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, x.Cinsiyet, Şehir = x.Sehirler.SehirAdi }).ToList();
                dataGridView1.DataSource = kaynak;
            }

            else
            {

                var kaynak = (from x in db.Musterilers
                              select new { ID=x.MusteriID,Adı_Soyadı = x.Ad + " " + x.Soyad, x.Email, x.Telefon, x.Cinsiyet, Şehir = x.Sehirler.SehirAdi }).ToList();
                dataGridView1.DataSource = kaynak;
            }
            textBox2.Clear();
            textBox1.Clear();
            comboBox2.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox2.TextLength == 11)
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz");
            }
            else
            {
               
               
                
                müsteriekle frm = new müsteriekle();
                frm.yeni = false;
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                DataSet1.MusterilerRow r = dataSet1.Musteriler.FindByMusteriID(id);
                frm.r = r;

                
                this.Hide();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    musterilerTableAdapter.Update(r);
                }
               
                
            }
        }

        private void müşterigörüntüle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
