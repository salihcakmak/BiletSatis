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
    public partial class sehirislemleri : Form
    {
        OtobusEntities db = new OtobusEntities();
        public sehirislemleri()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Şehir Adı Giriniz");
            }
            else
            {
                Sehirler yeni = new Sehirler();
                yeni.SehirAdi = textBox1.Text;
                db.Sehirlers.Add(yeni);
                db.SaveChanges();
                MessageBox.Show("Kayıt Eklendi");
                var kaynak = (from x in db.Sehirlers
                              select new { ID = x.SehirID, Şehirİsimleri = x.SehirAdi }).ToList();
                dataGridView1.DataSource = kaynak;
                textBox1.Clear();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kaynak = (from x in db.Sehirlers
                          select new { ID = x.SehirID, Şehirİsimleri = x.SehirAdi }).ToList();
            dataGridView1.DataSource = kaynak;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                int sayac = 0;
                int a = 0;
                int id = (int)dataGridView1.SelectedRows[i].Cells[0].Value;
                //-------------------------------
                var sil_mus = (from x in db.Sehirlers
                               where x.SehirID == id
                               select x).FirstOrDefault();
                //-----------------------
                var kontrol = (from x in db.Musterilers
                               select x).ToList();
                //--------------------
                foreach (var item in kontrol)
                {
                    a = Convert.ToInt32(item.SehirID.Value);
                    if (a == id)
                    {
                        sayac++;
                    }
                }
                if (sayac != 0)
                { MessageBox.Show("Bu kayıt Silinemez KULLANILIYOR"); }
                else
                {
                    db.Sehirlers.Remove(sil_mus);
                }



            }

            db.SaveChanges();
            var kaynak = (from x in db.Sehirlers
                          select new { ID = x.SehirID, Şehirİsimleri = x.SehirAdi }).ToList();
            dataGridView1.DataSource = kaynak;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void sehirislemleri_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var kaynak = (from x in db.Sehirlers
                              where(x.SehirAdi.Contains(textBox2.Text))
                              select new { ID = x.SehirID, Şehirİsimleri = x.SehirAdi }).ToList();
            dataGridView1.DataSource = kaynak;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen düzenlenecek Markayı seçiniz.");
            }
            else
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                Sehirler güncelle = (from x in db.Sehirlers
                                     where x.SehirID == id
                                     select x).FirstOrDefault();
                güncelle.SehirAdi = textBox1.Text;
                db.SaveChanges();
                var kaynak = (from x in db.Sehirlers
                              where (x.SehirAdi.Contains(textBox2.Text))
                              select new { ID = x.SehirID, Şehirİsimleri = x.SehirAdi }).ToList();
                dataGridView1.DataSource = kaynak;
                textBox1.Clear();
              
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void sehirislemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
