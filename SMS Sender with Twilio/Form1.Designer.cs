using System;

namespace SMS_Sender_with_Twilio
{
    partial class SMSSender
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMSSender));
            this.accountSidTextBox = new System.Windows.Forms.TextBox();
            this.accountSid = new System.Windows.Forms.Label();
            this.authToken = new System.Windows.Forms.Label();
            this.authTokenTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.twilioPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.panelSid = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasteSID = new System.Windows.Forms.PictureBox();
            this.PasteAuth = new System.Windows.Forms.PictureBox();
            this.PastePhoneNumber = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasteSID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasteAuth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PastePhoneNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // accountSidTextBox
            // 
            this.accountSidTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.accountSidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountSidTextBox.CausesValidation = false;
            resources.ApplyResources(this.accountSidTextBox, "accountSidTextBox");
            this.accountSidTextBox.ForeColor = System.Drawing.Color.White;
            this.accountSidTextBox.Name = "accountSidTextBox";
            // 
            // accountSid
            // 
            resources.ApplyResources(this.accountSid, "accountSid");
            this.accountSid.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.accountSid.Name = "accountSid";
            // 
            // authToken
            // 
            resources.ApplyResources(this.authToken, "authToken");
            this.authToken.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.authToken.Name = "authToken";
            // 
            // authTokenTextBox
            // 
            this.authTokenTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.authTokenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authTokenTextBox.CausesValidation = false;
            resources.ApplyResources(this.authTokenTextBox, "authTokenTextBox");
            this.authTokenTextBox.ForeColor = System.Drawing.Color.White;
            this.authTokenTextBox.Name = "authTokenTextBox";
            // 
            // phoneNumber
            // 
            resources.ApplyResources(this.phoneNumber, "phoneNumber");
            this.phoneNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.phoneNumber.Name = "phoneNumber";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.phoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumberTextBox.CausesValidation = false;
            resources.ApplyResources(this.phoneNumberTextBox, "phoneNumberTextBox");
            this.phoneNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.messageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageTextBox.CausesValidation = false;
            resources.ApplyResources(this.messageTextBox, "messageTextBox");
            this.messageTextBox.ForeColor = System.Drawing.Color.White;
            this.messageTextBox.Name = "messageTextBox";
            // 
            // message
            // 
            resources.ApplyResources(this.message, "message");
            this.message.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.message.Name = "message";
            // 
            // SendButton
            // 
            this.SendButton.AllowDrop = true;
            this.SendButton.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.SendButton, "SendButton");
            this.SendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SendButton.Name = "SendButton";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Name = "label1";
            // 
            // twilioPhoneNumberTextBox
            // 
            this.twilioPhoneNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.twilioPhoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.twilioPhoneNumberTextBox.CausesValidation = false;
            resources.ApplyResources(this.twilioPhoneNumberTextBox, "twilioPhoneNumberTextBox");
            this.twilioPhoneNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.twilioPhoneNumberTextBox.Name = "twilioPhoneNumberTextBox";
            // 
            // panelSid
            // 
            this.panelSid.BackColor = System.Drawing.Color.White;
            this.panelSid.ForeColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.panelSid, "panelSid");
            this.panelSid.Name = "panelSid";
            this.panelSid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSid_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Name = "richTextBox1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.exitButton);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // PasteSID
            // 
            resources.ApplyResources(this.PasteSID, "PasteSID");
            this.PasteSID.Name = "PasteSID";
            this.PasteSID.TabStop = false;
            this.PasteSID.Click += new System.EventHandler(this.PasteSID_Click);
            // 
            // PasteAuth
            // 
            resources.ApplyResources(this.PasteAuth, "PasteAuth");
            this.PasteAuth.Name = "PasteAuth";
            this.PasteAuth.TabStop = false;
            this.PasteAuth.Click += new System.EventHandler(this.PasteAuth_Click);
            // 
            // PastePhoneNumber
            // 
            resources.ApplyResources(this.PastePhoneNumber, "PastePhoneNumber");
            this.PastePhoneNumber.Name = "PastePhoneNumber";
            this.PastePhoneNumber.TabStop = false;
            this.PastePhoneNumber.Click += new System.EventHandler(this.PastePhoneNumber_Click);
            // 
            // SMSSender
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CausesValidation = false;
            this.Controls.Add(this.PastePhoneNumber);
            this.Controls.Add(this.PasteAuth);
            this.Controls.Add(this.PasteSID);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSid);
            this.Controls.Add(this.twilioPhoneNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.message);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.authTokenTextBox);
            this.Controls.Add(this.authToken);
            this.Controls.Add(this.accountSid);
            this.Controls.Add(this.accountSidTextBox);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SMSSender";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PasteSID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasteAuth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PastePhoneNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void title_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.TextBox accountSidTextBox;
        private System.Windows.Forms.Label accountSid;
        private System.Windows.Forms.Label authToken;
        private System.Windows.Forms.TextBox authTokenTextBox;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox twilioPhoneNumberTextBox;
        private System.Windows.Forms.Panel panelSid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PasteSID;
        private System.Windows.Forms.PictureBox PasteAuth;
        private System.Windows.Forms.PictureBox PastePhoneNumber;
    }
}
