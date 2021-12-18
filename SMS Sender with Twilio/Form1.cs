using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;                                                                                                   //to use the app we need to add twilio library
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace SMS_Sender_with_Twilio
{

    public partial class SMSSender : Form
    {
        public SMSSender()
        {

            InitializeComponent();

            Environment.SetEnvironmentVariable("twilioSid", authTokenTextBox.Text, EnvironmentVariableTarget.Machine);          //Setting new enviroment variables so
            Environment.SetEnvironmentVariable("twilioAuth", phoneNumberTextBox.Text, EnvironmentVariableTarget.Machine);       //we don't need to directly add them to our code
                                                                                                                                //to validate the login

            string accountSid = Environment.GetEnvironmentVariable("twilioSid");                                                //Getting the same enviroment variables we created 
            string authToken = Environment.GetEnvironmentVariable("twilioAuth");                                                //so we can use them to validate the login to Twilio

            TwilioClient.Init(accountSid, authToken);                                                                           //Initializing the connection with twilio 
                                                                                                                                //by using the enviroment variables we created


        }

        public void SendButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(accountSidTextBox.Text) || String.IsNullOrWhiteSpace(authTokenTextBox.Text)           //Checking for empty values so we can 
               || String.IsNullOrWhiteSpace(messageTextBox.Text) || String.IsNullOrWhiteSpace(phoneNumberTextBox.Text)          //avoid any exception while runing the app.
               || String.IsNullOrWhiteSpace(twilioPhoneNumberTextBox.Text))
            {

                MessageBox.Show("Please check for empty values!");                                                              //If we have empty values we show this message
                return;                                                                                     
            }




            var message = MessageResource.Create(                                                                           //We create the message
            body: messageTextBox.Text,                                                                                      //The message body is going to be our message textbox
            from: new Twilio.Types.PhoneNumber("whatsapp:" + twilioPhoneNumberTextBox.Text.Replace(" ", String.Empty)),     //The phone number from which the message is going to be send
            to: new Twilio.Types.PhoneNumber("whatsapp:" + phoneNumberTextBox.Text)                                         //The whatsapp string means we're going to send a whatsapp message
       );                                                                                                                   //If we want to send a sms we can remove the whatsapp string 
                                                                                                                            //but in order to do that we need a twilio premium account or our region
                                                                                                                            //should match with supported regions from twilio
                                                                                                                            //from(which phone number is going to send the message), to(the phone number that recieves the message
                                                                                                                            //we get the numbers from twilioPhoneNumberTextBox and phoneNumberTextBox


            MessageBox.Show("Your message has been sent!");                                                                 //A message to show that the message has arrived
            messageTextBox.Clear();                                                                                         //Empty messagetextbox and phonenumber in case we need to send another message
            phoneNumberTextBox.Clear();                                                                                     //to a different phone number
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelSid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PasteSID_Click(object sender, EventArgs e)
        {
            accountSidTextBox.Text = Clipboard.GetText();                                           //paste buttons
        }

        private void PasteAuth_Click(object sender, EventArgs e)
        {
            authTokenTextBox.Text = Clipboard.GetText();                                            
        }

        private void PastePhoneNumber_Click(object sender, EventArgs e)
        {
            twilioPhoneNumberTextBox.Text = Clipboard.GetText();
        }
    }
}
        
    

