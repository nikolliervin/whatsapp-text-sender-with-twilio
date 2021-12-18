using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SMS_Sender_with_Twilio
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void x_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = "chrome";
            process.StartInfo.Arguments = @"https://www.linkedin.com/in/ervin-nikolli-7298711b4/";
            process.Start();
        }

        private void githubLink_Click(object sender, EventArgs e)
        {
            
            
            
            var process = new Process(); 
            process.StartInfo.UseShellExecute = true; 
            process.StartInfo.FileName = "chrome"; 
            process.StartInfo.Arguments = @"https://github.com/nikolliervin"; 
            process.Start();
        }
    }
}
