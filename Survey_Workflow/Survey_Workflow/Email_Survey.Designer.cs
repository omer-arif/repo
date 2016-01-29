namespace Survey_Workflow
{
    partial class Email_Survey
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
            this.EmailListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailListBox1
            // 
            this.EmailListBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EmailListBox1.CheckOnClick = true;
            this.EmailListBox1.FormattingEnabled = true;
            this.EmailListBox1.Items.AddRange(new object[] {
            "email1.test@hotmail.com",
            "email2.test@hotmail.com",
            "email3.test@hotmail.com",
            "email4.test@hotmail.com",
            "email5.test@hotmail.com",
            "email6.test@hotmail.com",
            "email7.test@hotmail.com",
            "email8.test@hotmail.com",
            "email9.test@hotmail.com",
            "email10.test@hotmail.com",
            "email11.test@hotmail.com",
            "email12.test@hotmail.com",
            "email13.test@hotmail.com",
            "email14.test@hotmail.com",
            "Email15.test@hotmail.com"});
            this.EmailListBox1.Location = new System.Drawing.Point(121, 108);
            this.EmailListBox1.Name = "EmailListBox1";
            this.EmailListBox1.Size = new System.Drawing.Size(210, 154);
            this.EmailListBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select one or more emails form the given list below";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(327, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Proceed To Survey";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Email_Survey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailListBox1);
            this.Name = "Email_Survey";
            this.Text = "Email_Survey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox EmailListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}