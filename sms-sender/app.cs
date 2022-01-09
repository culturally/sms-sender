using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Specialized;
using System.Net;

namespace sms_sender
{
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();
        }

        private void app_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numberinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendb_Click(object sender, EventArgs e)
        {
            string num = numberinput.Text;
            string sms = smsinput.Text;
            WebClient client = new WebClient();
            byte[] res = client.UploadValues("http://textbelt.com/text", new NameValueCollection() {
                { "phone", num },
                { "message", sms },
                { "key", "textbelt" },
            });
            string resString = System.Text.Encoding.UTF8.GetString(res);
            //MessageBox.Show(resString, "Response");
            if (resString.Contains("true") == true)
            {
                MessageBox.Show("SMS Sent Successfuly", "Sent!");
            }
            else if (resString.Contains("Only one test text message is allowed per day.") == true)
            {
                MessageBox.Show("1 SMS Per Day!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (resString.Contains("disabled") == true)
            {
                MessageBox.Show("Service is down", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (resString.Contains("Missing") == true)
            {
                MessageBox.Show("Invalid Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
    }
}
