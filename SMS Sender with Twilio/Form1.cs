using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace SMS_Sender_with_Twilio
{

    public partial class SMSSender : Form
    {
        public SMSSender()
        {
            
            InitializeComponent();
            
            Environment.SetEnvironmentVariable("twilioSid", authTokenTextBox.Text, EnvironmentVariableTarget.Machine);
            Environment.SetEnvironmentVariable("twilioAuth", phoneNumberTextBox.Text, EnvironmentVariableTarget.Machine);

            string accountSid = Environment.GetEnvironmentVariable("twilioSid");
            string authToken = Environment.GetEnvironmentVariable("twilioAuth");

            TwilioClient.Init(accountSid, authToken);

            isEmptyTextBox();

        }

        public void SendButton_Click(object sender, EventArgs e)
        {
            




            var message = MessageResource.Create(
            body: messageTextBox.Text,
            from: new Twilio.Types.PhoneNumber("whatsapp:" + twilioPhoneNumberTextBox.Text),
            to: new Twilio.Types.PhoneNumber("whatsapp:" + phoneNumberTextBox.Text)
       );


            MessageBox.Show("Your message has been sent!");
            messageTextBox.Clear();
            phoneNumberTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelSid_Paint(object sender, PaintEventArgs e)
        {

        }

        

        
        



    }
}
        
    

