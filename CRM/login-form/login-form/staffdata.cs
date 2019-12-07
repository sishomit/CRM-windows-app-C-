using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_form
{
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }

        private void f_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        String Genderr;
        private void button1_Click(object sender, EventArgs e)
        {
          
              
           if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string fileName = "d:\\csharp\\staff\\staff_" + sname.Text + ".txt";
                if (File.Exists(fileName))
                    MessageBox.Show("StaffName already exist.\nsuggestion:Use numeber at the last of the name to save again");
                else
                {

                    using (StreamWriter objWriter = new StreamWriter(fileName, true))

                    {
                        objWriter.Write("Name: "+sname.Text);
                        objWriter.Write("\n");
                        objWriter.Write("Age: " + sage.Text);
                        objWriter.Write("\n");
                        objWriter.Write("Address: " + saddress.Text);
                        objWriter.Write("\n");
                        objWriter.Write("Gender: " + Genderr);
                        objWriter.Write("\n");
                        objWriter.Write("Stafflevel: " + stafflevel.Text);
                        objWriter.Write("\n");
                        objWriter.Write("Performance: " + staffperformance.Text);


                    }

                    MessageBox.Show("Details have been saved");


                }
                MessageBox.Show("Name: " + sname.Text + "\nAge: " + sage.Text + "\nAddress: " + saddress.Text + "\nGender: " + Genderr + "\nStaff Level: " + stafflevel.Text + "\nStaff Performance: " + staffperformance.Text);


            }



         
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void d_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Genderr = "Female";
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            Genderr = "Male";
        }

        private void a_TextChanged(object sender, EventArgs e)
        {

        }

       private void sage_ValueChanged(object sender, EventArgs e)
        {
           
        }
        
        private void sage_Validating(object sender, CancelEventArgs e)
        {
            int val = 0;
            Int32.TryParse(sage.Text, out val);
            if (string.IsNullOrWhiteSpace(sage.Text))
            {
                e.Cancel = true;
                sage.Focus();
                errorProviders.SetError(sage, "Age can not be left blank!");
               
            }
            else if (val < 18 | val > 60)
            {

                e.Cancel = true;
                sage.Focus();
                errorProviders.SetError(sage, "Staff age should be greater than 18 and less then 60!!");

            }
            else
       
            {
                e.Cancel = false;
                errorProviders.SetError(sage, "");
            }
        }

        private void sname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sname.Text))
            {
                e.Cancel = true;
                sname.Focus();
                errorProviders.SetError(sname, "Name can not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviders.SetError(sname, "");
            }
        }

        private void saddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(saddress.Text))
            {
                e.Cancel = true;
                sname.Focus();
                errorProviders.SetError(saddress, "Address can not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviders.SetError(saddress, "");
            }
        }

        private void sgender_Validating(object sender, CancelEventArgs e)
        {
            if (Male.Checked || radioButton2.Checked)
            {
                e.Cancel = false;
                errorProviders.SetError(sgender, "");
            }

            else
            {
                e.Cancel = true;
                sgender.Focus();
                errorProviders.SetError(sgender, "Choose one!");

            }
        }

        private void stafflevel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(stafflevel.Text))
            {
                e.Cancel = true;
                sname.Focus();
                errorProviders.SetError(stafflevel, "Select Staff Level!");
            }
            else
            {
                e.Cancel = false;
                errorProviders.SetError(stafflevel, "");
            }
        }

        private void staffperformance_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(staffperformance.Text))
            {
                e.Cancel = true;
                sname.Focus();
                errorProviders.SetError(staffperformance, "Performance can not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviders.SetError(staffperformance, "");
            }
        }
    }
}
