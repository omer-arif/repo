namespace Survey_Workflow
{
    partial class Phone_Survey
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
            this.phoneListBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contactDetails = new System.Windows.Forms.Panel();
            this.address = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contactDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // phoneListBox1
            // 
            this.phoneListBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.phoneListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneListBox1.FormattingEnabled = true;
            this.phoneListBox1.ItemHeight = 20;
            this.phoneListBox1.Items.AddRange(new object[] {
            "Contact1",
            "Contact2",
            "Contact3",
            "Contact4",
            "Contact5",
            "Contact6",
            "Contact7",
            "Contact8",
            "Contact9",
            "Contact10",
            "Contact11",
            "Contact12",
            "Contact13",
            "Contact14",
            "Contact15"});
            this.phoneListBox1.Location = new System.Drawing.Point(84, 77);
            this.phoneListBox1.Name = "phoneListBox1";
            this.phoneListBox1.Size = new System.Drawing.Size(175, 144);
            this.phoneListBox1.TabIndex = 5;
            this.phoneListBox1.Click += new System.EventHandler(this.Contact_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contact details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(694, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Please select the contact from available contact list given below.";
            // 
            // contactDetails
            // 
            this.contactDetails.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.contactDetails.Controls.Add(this.address);
            this.contactDetails.Controls.Add(this.email);
            this.contactDetails.Controls.Add(this.lname);
            this.contactDetails.Controls.Add(this.phonenumber);
            this.contactDetails.Controls.Add(this.label8);
            this.contactDetails.Controls.Add(this.mname);
            this.contactDetails.Controls.Add(this.label7);
            this.contactDetails.Controls.Add(this.fname);
            this.contactDetails.Controls.Add(this.label6);
            this.contactDetails.Controls.Add(this.label1);
            this.contactDetails.Controls.Add(this.label2);
            this.contactDetails.Controls.Add(this.label4);
            this.contactDetails.Controls.Add(this.label3);
            this.contactDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactDetails.Location = new System.Drawing.Point(84, 240);
            this.contactDetails.Name = "contactDetails";
            this.contactDetails.Size = new System.Drawing.Size(739, 184);
            this.contactDetails.TabIndex = 11;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(493, 120);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(232, 55);
            this.address.TabIndex = 14;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(493, 85);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(232, 26);
            this.email.TabIndex = 13;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(136, 115);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(200, 26);
            this.lname.TabIndex = 14;
            // 
            // phonenumber
            // 
            this.phonenumber.Location = new System.Drawing.Point(493, 49);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(232, 26);
            this.phonenumber.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Last Name";
            // 
            // mname
            // 
            this.mname.Location = new System.Drawing.Point(136, 81);
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(200, 26);
            this.mname.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Middle Name";
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(136, 49);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(200, 26);
            this.fname.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(315, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Proceed To Survey";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Phone_Survey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(925, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contactDetails);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phoneListBox1);
            this.Name = "Phone_Survey";
            this.Text = "Phone_Survey";
            this.contactDetails.ResumeLayout(false);
            this.contactDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox phoneListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel contactDetails;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox phonenumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}