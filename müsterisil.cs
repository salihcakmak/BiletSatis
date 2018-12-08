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
    public partial class müsterisil : Form
    {
        OtobusEntities db = new OtobusEntities();
        public müsterisil()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                int id = (int)dataGridView1.SelectedRows[i].Cells[0].Value;
                var sil_mus = (from x in db.Musterilers
                               where x.MusteriID == id
                               select x).FirstOrDefault();
                db.Musterilers.Remove(sil_mus);

            }

            db.SaveChanges();
            dataGridView1.DataSource = (from x in db.Musterilers
                                        select x).ToList();
            //musterilerBindingSource1.Position = musterilerBindingSource1.Find("ad", textBox2.Text);
        }

        private void müsterisil_Load(object sender, EventArgs e)
        {
         
            // TODO: This line of code loads data into the 'dataSet1.Sehirler' table. You can move, or remove it, as needed.
            this.sehirlerTableAdapter.Fill(this.dataSet1.Sehirler);
            // TODO: This line of code loads data into the 'dataSet1.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter.Fill(this.dataSet1.Musteriler);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            musterilerBindingSource1.Filter = "ad like '" + textBox1.Text + "%'";
        }

        private void müsterisil_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
            comboBox2.SelectedIndex = -1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {

            }
            else
            {
                var kaynak = (from x in db.Musterilers
                              where x.SehirID == (int)comboBox2.SelectedValue
                              select x).ToList();
                dataGridView1.DataSource = kaynak;
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {

            }
            else
            {
                dataGridView1.DataSource = (from x in db.Musterilers
                                            where x.Cinsiyet == comboBox1.SelectedItem.ToString()
                                            select x).ToList();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            musterilerBindingSource1.Filter = "soyad like '" + textBox2.Text + "%'";
        }

        private void müsterisil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void müsterisil_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            dataGridView1.DataSource = dataSet1.Musteriler;
        }
    }
}
