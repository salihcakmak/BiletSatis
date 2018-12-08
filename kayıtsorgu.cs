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
    public partial class kayıtsorgu : Form
    {
        public kayıtsorgu()
        {
            InitializeComponent();
        }
        OtobusEntities db = new OtobusEntities();

        private void kayıtsorgu_FormClosing(object sender, FormClosingEventArgs e)
        {
            kullanıcıgirişi frm = new kullanıcıgirişi();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Lütfen alanları doldurunuz.");
            }
            else
            {


                int id = Convert.ToInt32(textBox2.Text);
                string user = textBox1.Text;
                dataGridView1.DataSource = (from x in db.Logins
                                            where x.Username == user && x.PIN == id
                                            select x).ToList();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBox2.TextLength == 4)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kayıtsorgu_Load(object sender, EventArgs e)
        {

        }
    }
}
