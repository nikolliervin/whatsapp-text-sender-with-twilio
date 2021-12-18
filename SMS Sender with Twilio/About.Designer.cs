namespace SMS_Sender_with_Twilio
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.x = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.aboutPanel2 = new System.Windows.Forms.Panel();
            this.linkedInLink = new System.Windows.Forms.PictureBox();
            this.githubLink = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.githubLink)).BeginInit();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.BackColor = System.Drawing.Color.Transparent;
            this.x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.x.ForeColor = System.Drawing.Color.White;
            this.x.Location = new System.Drawing.Point(354, 4);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(15, 16);
            this.x.TabIndex = 0;
            this.x.Text = "X";
            this.x.Click += new System.EventHandler(this.x_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.x);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 116);
            this.panel1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Antipasto Pro ", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(14, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(327, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "WhatsApp Text Sender with Twilio";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.ForeColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(19, 137);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(212, 270);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // aboutPanel2
            // 
            this.aboutPanel2.BackColor = System.Drawing.Color.White;
            this.aboutPanel2.ForeColor = System.Drawing.Color.White;
            this.aboutPanel2.Location = new System.Drawing.Point(12, 137);
            this.aboutPanel2.Name = "aboutPanel2";
            this.aboutPanel2.Size = new System.Drawing.Size(1, 293);
            this.aboutPanel2.TabIndex = 3;
            // 
            // linkedInLink
            // 
            this.linkedInLink.Image = ((System.Drawing.Image)(resources.GetObject("linkedInLink.Image")));
            this.linkedInLink.Location = new System.Drawing.Point(46, 444);
            this.linkedInLink.Name = "linkedInLink";
            this.linkedInLink.Size = new System.Drawing.Size(21, 22);
            this.linkedInLink.TabIndex = 5;
            this.linkedInLink.TabStop = false;
            this.linkedInLink.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // githubLink
            // 
            this.githubLink.Image = ((System.Drawing.Image)(resources.GetObject("githubLink.Image")));
            this.githubLink.Location = new System.Drawing.Point(19, 444);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(21, 22);
            this.githubLink.TabIndex = 6;
            this.githubLink.TabStop = false;
            this.githubLink.Click += new System.EventHandler(this.githubLink_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(370, 486);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.linkedInLink);
            this.Controls.Add(this.aboutPanel2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(118, 32);
            this.Name = "About";
            this.Text = "About";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.githubLink)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Panel aboutPanel2;
        private System.Windows.Forms.PictureBox linkedInLink;
        private System.Windows.Forms.PictureBox githubLink;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}