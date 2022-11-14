using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void storeg_Click(object sender, EventArgs e)
        {
            مخزن s1 = new مخزن();
            s1.Show();
        }

        private void المخازنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            مخزن s1 = new مخزن();
            s1.Show();
        }

        private void مخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            مبيعات s2 = new مبيعات();
            s2.Show();
        }

        private void المسخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pay_Click(object sender, EventArgs e)
        {
            مبيعات s2 = new مبيعات();
            s2.Show();
        }

        private void Expenses_Click(object sender, EventArgs e)
        {
            Expenses E=new Expenses();
            E.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backprodect_Click(object sender, EventArgs e)
        {
            مرتجع_مبيعات m = new مرتجع_مبيعات();
            m.Show();
        }

        private void backsales_Click(object sender, EventArgs e)
        {
            مرتجع_مخزون M = new مرتجع_مخزون();
            M.Show();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
      Application.Exit(); 
        }

        private void adduser_Click(object sender, EventArgs e)
        {
            Adduser W = new Adduser();
            W.Show();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pricelist_Click(object sender, EventArgs e)
        {

        }
    }
}
