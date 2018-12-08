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
    public partial class otobüsekle : Form
    {
        OtobusEntities db = new OtobusEntities();
        public otobüsekle()
        {
            InitializeComponent();
        }

        private void otobüsekle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Markalar' table. You can move, or remove it, as needed.
            this.markalarTableAdapter.Fill(this.dataSet1.Markalar);
            comboBox1.SelectedIndex = -1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || numericUpDown1.Value == 0 || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Boş Alanları Doldurunuz");
            }
            else
            {
                Otobusler yeni = new Otobusler();
                yeni.Plaka = textBox1.Text;
                yeni.KoltukSayisi = (int)numericUpDown1.Value;
                yeni.MarkaID = (int)comboBox1.SelectedValue;
                db.Otobuslers.Add(yeni);
                db.SaveChanges();
                MessageBox.Show("Kayıt Eklendi");
                textBox1.Clear();
                numericUpDown1.Value = 0;
                comboBox1.SelectedIndex = -1;
                var kaynak = (from x in db.Otobuslers
                              select new { ID = x.OtobusID, Plaka = x.Plaka, KoltukSayısı = x.KoltukSayisi, Markası = x.Markalar.MarkaAdi }).ToList();
               // dataGridView1.DataSource = kaynak;
                dataGridView1.DataSource = kaynak;
                textBox1.Focus();
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kaynak = (from x in db.Otobuslers
                          select new { ID = x.OtobusID, Plaka = x.Plaka, KoltukSayısı = x.KoltukSayisi ,Markası=x.Markalar.MarkaAdi}).ToList();
            dataGridView1.DataSource = kaynak;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                int id = (int)dataGridView1.SelectedRows[i].Cells[0].Value;
                var sil_mus = (from x in db.Otobuslers
                               where x.OtobusID == id
                               select x).FirstOrDefault();
                db.Otobuslers.Remove(sil_mus);

            }

            db.SaveChanges();
            var kaynak = (from x in db.Otobuslers
                          select new { ID = x.OtobusID, Plaka = x.Plaka, KoltukSayısı = x.KoltukSayisi, Markası = x.Markalar.MarkaAdi }).ToList();
            dataGridView1.DataSource = kaynak;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.TextLength == 7)
            {
                e.Handled = true;
            }
        }

        private void otobüsekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                if (textBox1.Text == "" || numericUpDown1.Value == 0 || comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Boş Alanları Doldurunuz");
                }
                else
                {
                    Otobusler yeni = new Otobusler();
                    yeni.Plaka = textBox1.Text;
                    yeni.KoltukSayisi = (int)numericUpDown1.Value;
                    yeni.MarkaID = (int)comboBox1.SelectedValue;
                    db.Otobuslers.Add(yeni);
                    db.SaveChanges();
                    MessageBox.Show("Kayıt Eklendi");
                    textBox1.Clear();
                    numericUpDown1.Value = 0;
                    comboBox1.SelectedIndex = -1;
                    var kaynak = (from x in db.Otobuslers
                                  select new { ID = x.OtobusID, Plaka = x.Plaka, KoltukSayısı = x.KoltukSayisi, Markası = x.Markalar.MarkaAdi }).ToList();
                    dataGridView1.DataSource = kaynak;
                    textBox1.Focus();
                }
            }
            else if (e.KeyCode==Keys.Escape)
            {
                 textBox1.Clear();
                    numericUpDown1.Value = 0;
                    comboBox1.SelectedIndex = -1;
            }
        }
    }
}
