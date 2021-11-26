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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountSidTextBox
            // 
            this.accountSidTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.accountSidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountSidTextBox.CausesValidation = false;
            this.accountSidTextBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountSidTextBox.ForeColor = System.Drawing.Color.White;
            this.accountSidTextBox.Location = new System.Drawing.Point(202, 224);
            this.accountSidTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.accountSidTextBox.Name = "accountSidTextBox";
            this.accountSidTextBox.Size = new System.Drawing.Size(270, 17);
            this.accountSidTextBox.TabIndex = 1;
            // 
            // accountSid
            // 
            this.accountSid.AutoSize = true;
            this.accountSid.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accountSid.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.accountSid.Location = new System.Drawing.Point(13, 221);
            this.accountSid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountSid.Name = "accountSid";
            this.accountSid.Size = new System.Drawing.Size(90, 20);
            this.accountSid.TabIndex = 2;
            this.accountSid.Text = "Account SID:";
            // 
            // authToken
            // 
            this.authToken.AutoSize = true;
            this.authToken.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.authToken.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.authToken.Location = new System.Drawing.Point(13, 273);
            this.authToken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authToken.Name = "authToken";
            this.authToken.Size = new System.Drawing.Size(84, 20);
            this.authToken.TabIndex = 3;
            this.authToken.Text = "Auth Token:";
            // 
            // authTokenTextBox
            // 
            this.authTokenTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.authTokenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authTokenTextBox.CausesValidation = false;
            this.authTokenTextBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authTokenTextBox.ForeColor = System.Drawing.Color.White;
            this.authTokenTextBox.Location = new System.Drawing.Point(202, 277);
            this.authTokenTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.authTokenTextBox.Name = "authTokenTextBox";
            this.authTokenTextBox.Size = new System.Drawing.Size(270, 17);
            this.authTokenTextBox.TabIndex = 4;
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.phoneNumber.Location = new System.Drawing.Point(13, 328);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(106, 20);
            this.phoneNumber.TabIndex = 5;
            this.phoneNumber.Text = "Phone Number:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.phoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumberTextBox.CausesValidation = false;
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(202, 332);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(270, 17);
            this.phoneNumberTextBox.TabIndex = 6;
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.messageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageTextBox.CausesValidation = false;
            this.messageTextBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageTextBox.ForeColor = System.Drawing.Color.White;
            this.messageTextBox.Location = new System.Drawing.Point(202, 436);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(270, 17);
            this.messageTextBox.TabIndex = 7;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.message.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.message.Location = new System.Drawing.Point(15, 432);
            this.message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(71, 20);
            this.message.TabIndex = 8;
            this.message.Text = "Message: ";
            // 
            // SendButton
            // 
            this.SendButton.AllowDrop = true;
            this.SendButton.BackColor = System.Drawing.Color.White;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SendButton.Location = new System.Drawing.Point(375, 547);
            this.SendButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(106, 32);
            this.SendButton.TabIndex = 9;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(13, 382);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Twilio Phone Number:";
            // 
            // twilioPhoneNumberTextBox
            // 
            this.twilioPhoneNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.twilioPhoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.twilioPhoneNumberTextBox.CausesValidation = false;
            this.twilioPhoneNumberTextBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.twilioPhoneNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.twilioPhoneNumberTextBox.Location = new System.Drawing.Point(202, 386);
            this.twilioPhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.twilioPhoneNumberTextBox.Name = "twilioPhoneNumberTextBox";
            this.twilioPhoneNumberTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.twilioPhoneNumberTextBox.Size = new System.Drawing.Size(270, 17);
            this.twilioPhoneNumberTextBox.TabIndex = 11;
            // 
            // panelSid
            // 
            this.panelSid.BackColor = System.Drawing.Color.White;
            this.panelSid.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelSid.Location = new System.Drawing.Point(191, 247);
            this.panelSid.Name = "panelSid";
            this.panelSid.Size = new System.Drawing.Size(290, 1);
            this.panelSid.TabIndex = 12;
            this.panelSid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSid_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(191, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 1);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(191, 459);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 1);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(191, 409);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 1);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Location = new System.Drawing.Point(191, 355);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 1);
            this.panel5.TabIndex = 13;
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(483, 3);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(28, 28);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Antipasto Pro ", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(118, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(375, 76);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "WhatsApp Text Sender with Twilio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 165);
            this.panel1.TabIndex = 0;
            // 
            // SMSSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(515, 680);
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
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SMSSender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
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
    }
}
