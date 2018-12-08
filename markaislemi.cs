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
    public partial class markaislemi : Form
    {
        OtobusEntities db = new OtobusEntities();
        public markaislemi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Marka İsmi Giriniz");
            }
            else
            {
                Markalar yeni = new Markalar();
                yeni.MarkaAdi = textBox1.Text;
                db.Markalars.Add(yeni);
                db.SaveChanges();
                MessageBox.Show("Marka Başarıyla Eklendi");
                var kaynak = (from x in db.Markalars
                              select new { ID = x.MarkaId, Markaİsimleri = x.MarkaAdi }).ToList();
                dataGridView1.DataSource = kaynak;
                textBox1.Clear();
                textBox1.Focus();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kaynak =(from x in db.Markalars
                             select new {ID=x.MarkaId,Markaİsimleri=x.MarkaAdi}).ToList();
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
                var sil_mus = (from x in db.Markalars
                               where x.MarkaId == id
                               select x).FirstOrDefault();
                //-----------------------
                var kontrol = (from x in db.Otobuslers
                               select x).ToList();
                //--------------------
                foreach (var item in kontrol)
                {
                    a = Convert.ToInt32(item.MarkaID.Value);
                    if (a == id)
                    {
                        sayac++;
                    }
                }
                if (sayac != 0)
                { MessageBox.Show("Bu kayıt Silinemez KULLANILIYOR"); }
                else
                {
                    db.Markalars.Remove(sil_mus);
                }



            }

            db.SaveChanges();
            var kaynak = (from x in db.Markalars
                          select new { ID = x.MarkaId, Markaİsimleri = x.MarkaAdi }).ToList();
            dataGridView1.DataSource = kaynak;
            textBox1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var kaynak=(from x in db.Markalars
                            where ( x.MarkaAdi.Contains(textBox2.Text))
                            select new { ID = x.MarkaId, Markaİsimleri = x.MarkaAdi } ).ToList();
            dataGridView1.DataSource = kaynak; //db.Markalars.Where(x => x.MarkaAdi.Contains(textBox2.Text)).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void markaislemi_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Marka İsmi Giriniz");
            }
            else
            {
                Markalar yeni = new Markalar();
                yeni.MarkaAdi = textBox1.Text;
                db.Markalars.Add(yeni);
                db.SaveChanges();
                MessageBox.Show("Marka Başarıyla Eklendi");
                var kaynak = (from x in db.Markalars
                              select new { ID = x.MarkaId, Markaİsimleri = x.MarkaAdi }).ToList();
                dataGridView1.DataSource = kaynak;
                textBox1.Clear();
                textBox1.Focus();
            }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                
                textBox2.Clear();
            }
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

                Markalar güncelle = (from x in db.Markalars
                                     where x.MarkaId == id
                                     select x).FirstOrDefault();
                güncelle.MarkaAdi = textBox1.Text;
                db.SaveChanges();
                var kaynak = (from x in db.Markalars
                              select new { ID = x.MarkaId, Markaİsimleri = x.MarkaAdi }).ToList();
                dataGridView1.DataSource = kaynak;
                textBox1.Clear();
            }

        }

        private void markaislemi_Load(object sender, EventArgs e)
        {

        }

        private void markaislemi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
