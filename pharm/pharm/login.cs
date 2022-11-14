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
    public partial class login : Form
    {
        private Log _Log;
        public login()
        {
            _Log = Log.GetInstance();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proxy check = new Proxy();
            WebRequest request = WebRequest.Create("http://localhost:90/medical/APIs/login/login.php");
            request.Method = "POST";// the method to send data
            request.ContentType = "application/x-www-form-urlencoded"; // send the data (Very Important)

            string useremail = textUseremail.Text;
            string password = textPassword.Text;
            string postData = "email=" + useremail + "&password=" + password;

            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] data = enc.GetBytes(postData);
            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);


            WebResponse response = request.GetResponse();
            Stream stream2 = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream2);
            string result = sr.ReadLine();
            if (result == "1")
            {

                UserInfo.userEmail = useremail;
                check.checkType(this);
                _Log.LoggingDetails("logger.txt","Logged In");
                
            }
            else
            {
                MessageBox.Show(result);
              

            }
        }

        private void button1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textUseremail.Text))
            {
                e.Cancel = true;
                textUseremail.Focus();
                textPassword.Focus();
                errorProvider.SetError(textUseremail, "Pleas Enter Your Email");
                errorProvider.SetError(textPassword, "Pleas Enter Your Password");

            }

            else
                {
                e.Cancel = true;
                errorProvider.SetError(textUseremail, null);
                errorProvider.SetError(textPassword, null);

            }
        }
        }
    }

