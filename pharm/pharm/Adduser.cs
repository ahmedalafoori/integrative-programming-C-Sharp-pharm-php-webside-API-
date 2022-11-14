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
    public partial class Adduser : Form
    {
        private Log _Log;

        public Adduser()
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

        private void Select_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://localhost:90/medical/APIs/Adduser/SelectdataGreatViewAdduser/Select.php");
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
                ds.Tables[0].TableName = "users";
                dataGridView1.DataSource = ds.Tables["users"];


            }
            else
            {
                MessageBox.Show(menuBreak);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Select_Click(sender, e);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://localhost:90/medical/APIs/Adduser/UpdatedataGreateViewAdduser/Update.php");
            request.Method = "POST";// the method to send data
            request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)
            string usersid = textBox7.Text;
            string usersemail = textBox1.Text;
            string userspassword = textBox2.Text;
            string usersname = textBox3.Text;
            string usersnumber = textBox4.Text;


            string postData = "&id=" + usersid + "&email=" + usersemail + "&password=" + userspassword + "&name=" + usersname + "&number=" + usersnumber + "&requesttype=update";

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
                _Log.LoggingDetails("logger.txt", "Update  user");



            }
            else
            {
                MessageBox.Show(menuBreak);
            }
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


            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://localhost:90/medical/APIs/Adduser/DeletedataGreatViewAdduser/Delete.php");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded"; 
            string usersid = textBox7.Text;


            string postData = "&id=" + usersid;

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
                _Log.LoggingDetails("logger.txt", "Delete User");




            }
            else
            {
                MessageBox.Show(menuBreak);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://localhost:90/medical/APIs/Adduser/insertdataGreatViewAdduser/insert.php");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded"; 
            string usersid = textBox7.Text;
            string usersemail = textBox1.Text;
            string userspassword = textBox2.Text;
            string usersname = textBox3.Text;
            string usersnumber = textBox4.Text;


            string postData = "&id=" + usersid + "&email=" + usersemail + "&password=" + userspassword + "&name=" + usersname + "&number=" + usersnumber + "&requesttype=update";

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
                _Log.LoggingDetails("logger.txt", "add user");



            }
            else
            {
                MessageBox.Show(menuBreak);
            }
        }

        private void Adduser_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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
    

