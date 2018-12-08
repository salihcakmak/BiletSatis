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
    public partial class Form1 : Form
    {
        OtobusEntities db = new OtobusEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Sehirler' table. You can move, or remove it, as needed.
            this.sehirlerTableAdapter.Fill(this.dataSet1.Sehirler);

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

           
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
                
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void otobüsEkleSilGöruntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otobüsekle frm = new otobüsekle();
            frm.Show();
            this.Hide();
        }

        private void biletOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Otobuskayit frm = new Otobuskayit();
            //frm.MdiParent = this;
            //frm.Show();
            //this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            müsteriekle frm = new müsteriekle();
            frm.yeni = true;

            
            DataSet1.MusterilerRow r = dataSet1.Musteriler.NewMusterilerRow();
            frm.r = r;

            if (frm.ShowDialog() == DialogResult.OK && frm.yeni1 == false)
            {
                dataSet1.Musteriler.AddMusterilerRow(r);
                musterilerTableAdapter1.Update(r);
                this.Show();

            }
            else {
                this.Show();
            }
          
            //else
            //{
            //    this.Hide();
            //    müsteriekle frm1 = new müsteriekle();
            //    frm1.yeni = true;


            //    DataSet1.MusterilerRow r1 = dataSet1.Musteriler.NewMusterilerRow();
            //    frm.r = r1;

            //    if (frm1.ShowDialog() == DialogResult.OK && frm1.yeni1 == false)
            //    {
            //        dataSet1.Musteriler.AddMusterilerRow(r1);
            //        musterilerTableAdapter1.Update(r1);

            //    }
            //    else { this.Show(); }
        
            

            

            
            
        }

        private void markaİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            markaislemi frm = new markaislemi();
            frm.Show();
            this.Hide();
        }

        private void otobüsSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otobüsekle frm = new otobüsekle();
            frm.Show();
            this.Hide();
        }

        private void şehirİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sehirislemleri frm = new sehirislemleri();
            frm.Show();
            this.Hide();
        }

        private void müşteriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            müşterigörüntüle frm = new müşterigörüntüle();
            frm.Show();
            this.Hide();
        }

        private void müşteriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            müsterisil frm = new müsterisil();
            frm.Show();
            this.Hide();
        }

        private void çalışanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ekle frm = new ekle();
            frm.Show();
            this.Hide();
        }

        private void çalışansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            görüntüle frm = new görüntüle();
            frm.Show();
            this.Hide();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            görüntüle frm = new görüntüle();
            frm.Show();
            this.Hide();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sil frm = new sil();
            frm.Show();
            this.Hide();
        }
    }
}
