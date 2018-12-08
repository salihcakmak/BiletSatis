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
    public partial class sil : Form
    {
        OtobusEntities db = new OtobusEntities();
        public sil()
        {
            InitializeComponent();
        }

        private void sil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CalisanTipleri' table. You can move, or remove it, as needed.
            this.calisanTipleriTableAdapter.Fill(this.dataSet1.CalisanTipleri);
            // TODO: This line of code loads data into the 'dataSet1.Calisanlar' table. You can move, or remove it, as needed.
            this.calisanlarTableAdapter.Fill(this.dataSet1.Calisanlar);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                int id = (int)dataGridView1.SelectedRows[i].Cells[0].Value;
                var sil_mus = (from x in db.Calisanlars
                               where x.PersonelID == id
                               select x).FirstOrDefault();
                db.Calisanlars.Remove(sil_mus);

            }

            db.SaveChanges();
            dataGridView1.DataSource = (from x in db.Calisanlars
                                        select x).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calisanlarBindingSource.Filter = "ad like '" + textBox1.Text + "%'";
        }

        private void sil_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {

            }
            else
            {
                var kaynak = (from x in db.Calisanlars
                              where x.CalisanTipID == (int)comboBox1.SelectedValue
                              select x).ToList();
                dataGridView1.DataSource = kaynak;
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calisanlarBindingSource.Filter = "soyad like '" + textBox2.Text + "%'";
        }

        private void sil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            dataGridView1.DataSource = dataSet1.Calisanlar;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
