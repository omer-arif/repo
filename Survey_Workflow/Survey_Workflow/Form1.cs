using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey_Workflow
{
    public partial class User : Form
    {
        public User()
        {
           
            
            InitializeComponent();
            //Phone
            this.chart1.Series[0].Points.AddXY("Survey1" , 10);
            this.chart1.Series[0].Points.AddXY("Survey2", 20);
            this.chart1.Series[0].Points.AddXY("Survey3", 40);
            this.chart1.Series[0].Points.AddXY("Survey4", 40);
            this.chart1.Series[0].Points.AddXY("Survey5", 15);
            //Email
            this.chart1.Series[1].Points.AddXY("Survey1", 83);
            this.chart1.Series[1].Points.AddXY("Survey2", 45);
            this.chart1.Series[1].Points.AddXY("Survey3", 18);
            this.chart1.Series[1].Points.AddXY("Survey4", 31);
            this.chart1.Series[1].Points.AddXY("Survey5", 78);

            welcome.ReadOnly = true;
        }
       

        private void conductSurvey_Click(object sender, EventArgs e)
        {
            if (Survey.Controls.OfType<RadioButton>().Any(x => x.Checked))
            {

                SelectSurvey select = new SelectSurvey();
                select.ShowDialog();
            }
            else
                MessageBox.Show("Please select one survey survey from given options.");
      
        }

    

        

    }
}
