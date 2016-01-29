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
    public partial class Phone_Survey : Form
    {
        public Phone_Survey()
        {
            InitializeComponent();
            fname.ReadOnly = true;
            mname.ReadOnly = true;
            lname.ReadOnly = true;
            phonenumber.ReadOnly = true;
            email.ReadOnly = true;
            address.ReadOnly = true;
     
        }
        public void myContactDetails(string Fname, string Mname, string Lname,  string Phone, string Email, string Address)
       {
           fname.Text = Fname;
           mname.Text = Mname;
           lname.Text = Lname;
           phonenumber.Text =Phone;
           email.Text = Email;
           address.Text = Address;
       }

        private void Contact_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(phoneListBox1.SelectedItem) == "Contact1")
            {
                myContactDetails("omer1", " abc1 ", "arif1", "+923435105549", "email1@outlook.com", "Location1");
            }
            else if (Convert.ToString(phoneListBox1.SelectedItem) == "Contact2")
            {
                myContactDetails("omer2", " abc2 ", "arif2", "+923435165549", "email@outlook.com2", "Location2");
            }
            else if (Convert.ToString(phoneListBox1.SelectedItem) == "Contact3")
            {
                myContactDetails("omer3", " abc3 ", "arif3", "+923435165549", "email@outlook.com3", "Location3");
            }
            else if (Convert.ToString(phoneListBox1.SelectedItem) == "Contact4")
            {
                myContactDetails("omer4", " abc4 ", "arif4", "+923435145549", "email@outlook.com4", "Location4");
            }
            else if (Convert.ToString(phoneListBox1.SelectedItem) == "Contact5")
            {
                myContactDetails("omer5", " abc5 ", "arif5", "+923435545549", "email@outlook.com5", "Location5");
            }
            else if (Convert.ToString(phoneListBox1.SelectedItem) == "Contact6")
            {
                myContactDetails("omer6", " abc6", "arif6", "+923435645549", "email@outlook.com6", "Location6");
            }
            else if (Convert.ToString(phoneListBox1.SelectedItem) == "Contact7")
            {
                myContactDetails("omer7", " abc7 ", "arif7", "+923435745549", "email@outlook.com7", "Location7");
            }
            else if (Convert.ToString(phoneListBox1.SelectedItem) == "Contact8")
            {
                myContactDetails("omer8", " abc8 ", "arif8", "+923435845549", "email@outlook.com8", "Location8");
            }
            else if (Convert.ToString(phoneListBox1.SelectedItem) == "Contact9")
            {
                myContactDetails("omer9", " abc9", "arif9", "+923435945549", "email@outlook.com9", "Location9");
            }
            else if (Convert.ToString(phoneListBox1.SelectedItem) == "Contact10")
            {
                myContactDetails("omer10", " abc10 ", "arif10", "+923431045549", "email@outlook.com10", "Location10");
            }
            else if (Convert.ToString(phoneListBox1.SelectedItem) == "Contact11")
            {
                myContactDetails("omer11", " abc11 ", "arif11", "+923431145549", "email@outlook.com11", "Location11");
            }
            else if (Convert.ToString(phoneListBox1.SelectedItem) == "Contact12")
            {
                myContactDetails("omer12", " abc12", "arif12", "+923431245549", "email@outlook.com12", "Location12");
            }
            else if (Convert.ToString(phoneListBox1.SelectedItem) == "Contact13")
            {
                myContactDetails("omer13", " abc13", "arif13", "+923431345549", "email@outlook.com13", "Location13");
            }
            else if (Convert.ToString(phoneListBox1.SelectedItem) == "Contact14")
            {
                myContactDetails("omer14", " abc14 ", "arif14", "+923431145549", "email@outlook.com14", "Location14");
            }
            else if (Convert.ToString(phoneListBox1.SelectedItem) == "Contact15")
            {
                myContactDetails("omer15", " abc15", "arif15", "+923431345549", "email@outlook.com15", "Location15");
            }
            
        }
    }
}
