using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharm
{
    public partial class مرتجع_مبيعات : Form
    {
        private Log _Log;

        public مرتجع_مبيعات()
        {
            _Log = Log.GetInstance();

            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
            f.Hide();
        }

        private void مرتجع_مشتريات_Load(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void back_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
            f.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Select_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://localhost:90/medical/APIs/Sold/SelectdataGreatViewSold/Select.php");
            request.Method = "POST";// the method to send data
            request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

            string postData = "requesttype=select";

            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] data = enc.GetBytes(postData);
            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);

            WebResponse response = request.GetResponse();
            Stream stream2 = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream2);

            string menuBreak = sr.ReadToEnd();

            if (menuBreak != "Sorry, No food in this menu")
            {
                StringReader SR = new StringReader(menuBreak);
                DataSet ds = new DataSet();
                ds.ReadXml(SR);
                ds.Tables[0].TableName = "sold";
                dataGridView1.DataSource = ds.Tables["sold"];


            }
            else
            {
                MessageBox.Show(menuBreak);
            }
        }

        private void back_Click_2(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
            f.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Select_Click(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://localhost:90/medical/APIs/Sold/UpdatedataGreateViewSold/Update.php");
            request.Method = "POST";// the method to send data
            request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)
            string userid = textBox7.Text;
            string username = textBox1.Text;
            string phoneusername = textBox2.Text;
            string discount = textBox3.Text;
            string prodect = textBox4.Text;
            string amount = textBox5.Text;

            string postData = "&id=" + userid + "&name=" + username + "&contact=" + phoneusername + "&discount=" + discount + "&item=" + prodect + "&amount=" + amount + "&requesttype=update";

            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] data = enc.GetBytes(postData);
            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);

            WebResponse response = request.GetResponse();
            Stream stream2 = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream2);

            string menuBreak = sr.ReadToEnd();
            MessageBox.Show(menuBreak);
            if (menuBreak != "Sorry, error accured")
            {
                Select_Click(sender, e);
                textBox7.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                _Log.LoggingDetails("logger.txt", "Update");

            }
            else
            {
                MessageBox.Show(menuBreak);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://localhost:90/medical/APIs/Sold/DeletedataGreatViewSold/Delete.php");
            request.Method = "POST";// the method to send data
            request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)
            string userid = textBox7.Text;


            string postData = "&id=" + userid;

            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] data = enc.GetBytes(postData);
            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);

            WebResponse response = request.GetResponse();
            Stream stream2 = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream2);

            string menuBreak = sr.ReadToEnd();
            MessageBox.Show(menuBreak);
            if (menuBreak != "Sorry, error accured")
            {
                Select_Click(sender, e);
                textBox7.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                _Log.LoggingDetails("logger.txt", "Delete");


            }
            else
            {
                MessageBox.Show(menuBreak);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://localhost:90/medical/APIs/Sold/insertdataGreatViewSold/insert.php");
            request.Method = "POST";// the method to send data
            request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)
            string userid = textBox7.Text;
            string username = textBox1.Text;
            string phoneusername = textBox2.Text;
            string discount = textBox3.Text;
            string prodect = textBox4.Text;
            string amount = textBox5.Text;

            string postData = "&id=" + userid + "&name=" + username + "&contact=" + phoneusername + "&discount=" + discount + "&item=" + prodect + "&amount=" + amount + "&requesttype=update";

            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] data = enc.GetBytes(postData);
            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);

            WebResponse response = request.GetResponse();
            Stream stream2 = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream2);

            string menuBreak = sr.ReadToEnd();
            MessageBox.Show(menuBreak);
            if (menuBreak != "Sorry, error accured")
            {
                Select_Click(sender, e);
                textBox7.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                _Log.LoggingDetails("logger.txt", "Insert");
            }
            else
            {
                MessageBox.Show(menuBreak);
            }
        }

        private void storeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void storeBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void inventory_Paint(object sender, PaintEventArgs e)
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }
    }
    }
    
    
    
    

