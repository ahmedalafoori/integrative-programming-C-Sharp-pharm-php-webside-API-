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
    public partial class مرتجع_مخزون : Form
    {
        public مرتجع_مخزون()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {

            Form1 f = new Form1();
            f.Show();
            this.Hide();
            f.Hide();
        }
    }
}
