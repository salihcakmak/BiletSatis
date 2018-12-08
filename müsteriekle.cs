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
    public partial class müsteriekle : Form
    {

        OtobusEntities db = new OtobusEntities();
        public bool yeni;
        public bool yeni1=true;
      public  DataSet1.MusterilerRow r;
        public müsteriekle()
        {
            InitializeComponent();
        }

        private void müsteriekle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Sehirler' table. You can move, or remove it, as needed.
            this.sehirlerTableAdapter.Fill(this.dataSet1.Sehirler);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                src_to_db();
                //DialogResult = DialogResult.OK;
            
          
            //if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""  )

            //{ MessageBox.Show("Lütfen Boş Alanları Doldurunuz."); }
            //else
            //{
            //    Musteriler yeni = new Musteriler();
            //    yeni.Ad = textBox1.Text;
            //    yeni.Soyad = textBox2.Text;
            //    yeni.Email = textBox3.Text;
            //    yeni.Telefon = Convert.ToInt64(textBox4.Text);
            //    if (radioButton1.Checked == true)
            //    {
            //        yeni.Cinsiyet = radioButton1.Text;
            //    }
            //    else
            //    {
            //        yeni.Cinsiyet = radioButton2.Text;
            //    }
            //    yeni.SehirID = (int)comboBox1.SelectedValue;
            //    db.Musterilers.Add(yeni);
            //    MessageBox.Show("basarıyla eklendı");
            //    db.SaveChanges();
            //    textBox1.Clear();
            //    textBox2.Clear();
            //    textBox3.Clear();
            //    textBox4.Clear();
            //    comboBox1.SelectedIndex = -1;
            //    radioButton1.Checked = false;
            //    radioButton2.Checked = false;
            //}
            //Musteriler yeni = new Musteriler();
            //yeni.Ad = "sas";
            //yeni.Soyad = "eqwe";
            //yeni.Email = "dsadsa";
            //yeni.Telefon = 123213;

            //yeni.Cinsiyet = "erkek";



            //yeni.SehirID = 1;
            //db.Musterilers.Add(yeni);
            //MessageBox.Show("basarıyla eklendı");
            //db.SaveChanges();
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

        private void müsteriekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (yeni == false)
            {
               
                müşterigörüntüle abc = new müşterigörüntüle();
                abc.Show();
                this.Hide();
            }
            
                        
        }

        private void müsteriekle_Shown(object sender, EventArgs e)
        {
            if (yeni)
                temizle();
            else
                db_to_src();
        }
        private void db_to_src()
        {
            textBox1.Text = r.Ad;
            textBox2.Text = r.Soyad;
            textBox3.Text = r.Email;
            textBox4.Text = r.Telefon.ToString();
            if (r.Cinsiyet=="Erkek")
            {
                radioButton1.Checked = true;
            }
            else { radioButton2.Checked = true; }
            comboBox1.SelectedValue = r.SehirID;
           
        }

        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            radioButton2.Checked = false;
            radioButton1.Checked = false;
            comboBox1.SelectedIndex = -1;
           
        }
        private void src_to_db()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")

            { MessageBox.Show("Lütfen Boş Alanları Doldurunuz."); }
            else
            {
                yeni1 = false;
                r.Ad = textBox1.Text;
                r.Soyad = textBox2.Text;
                r.Email = textBox3.Text;
                r.Telefon = Convert.ToInt64(textBox4.Text);
                if (radioButton1.Checked == true)
                {
                    r.Cinsiyet = radioButton1.Text;
                }
                else
                {
                    r.Cinsiyet = radioButton2.Text;
                }
                r.SehirID = (int)comboBox1.SelectedValue;
                DialogResult = DialogResult.OK;


                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                comboBox1.SelectedIndex = -1;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
