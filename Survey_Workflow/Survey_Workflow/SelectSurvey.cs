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
    public partial class SelectSurvey : Form
    {
        public SelectSurvey()
        {
            InitializeComponent();
        }

        private void PhoneSurvey_Click(object sender, EventArgs e)
        {
            Phone_Survey ps = new Phone_Survey();
            ps.ShowDialog();
        }

        private void EmailSurvey_Click(object sender, EventArgs e)
        {
            Email_Survey es = new Email_Survey();
            es.ShowDialog();
        }

       

    }
}
