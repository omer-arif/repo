namespace Survey_Workflow
{
    partial class SelectSurvey
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
            this.EmailSurvey = new System.Windows.Forms.Button();
            this.PhoneSurvey = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmailSurvey
            // 
            this.EmailSurvey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailSurvey.Location = new System.Drawing.Point(299, 105);
            this.EmailSurvey.Name = "EmailSurvey";
            this.EmailSurvey.Size = new System.Drawing.Size(132, 32);
            this.EmailSurvey.TabIndex = 7;
            this.EmailSurvey.Text = "Email Survey";
            this.EmailSurvey.UseVisualStyleBackColor = true;
            this.EmailSurvey.Click += new System.EventHandler(this.EmailSurvey_Click);
            // 
            // PhoneSurvey
            // 
            this.PhoneSurvey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneSurvey.Location = new System.Drawing.Point(161, 105);
            this.PhoneSurvey.Name = "PhoneSurvey";
            this.PhoneSurvey.Size = new System.Drawing.Size(132, 32);
            this.PhoneSurvey.TabIndex = 6;
            this.PhoneSurvey.Text = "Phone Survey ";
            this.PhoneSurvey.UseVisualStyleBackColor = true;
            this.PhoneSurvey.Click += new System.EventHandler(this.PhoneSurvey_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select the Type of survey ou want to conduct";
            // 
            // SelectSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(597, 231);
            this.Controls.Add(this.EmailSurvey);
            this.Controls.Add(this.PhoneSurvey);
            this.Controls.Add(this.label3);
            this.Location = new System.Drawing.Point(100, 150);
            this.Name = "SelectSurvey";
            this.Text = "SelectSurvey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EmailSurvey;
        private System.Windows.Forms.Button PhoneSurvey;
        private System.Windows.Forms.Label label3;

    }
}