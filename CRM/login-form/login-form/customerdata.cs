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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void label7_Click(object sender, EventArgs e)
        {

        }

        
        String Genderr;
        private void button1_Click(object sender, EventArgs e)
        {
            string check = "";
            if (t.Checked)
            {
                check = "Reading";
            }
            if (y.Checked)
            {
                check = check + " \nPlay basketball";
            }
            if (kk.Checked)
            {
                check = check + " \nWalking and Running";
            }
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string fileName = "d:\\csharp\\customer\\customer_" + cname.Text + ".txt";
                if (File.Exists(fileName))
                    MessageBox.Show("Customer already exist.suggestion:Use numeber at the last of the name to save again");
                else
                {

                    using (StreamWriter objWriter = new StreamWriter(fileName, true))

                    {
                        objWriter.Write("Name: " + cname.Text);
                        objWriter.Write("\n");
                        objWriter.Write("Age: " + cage.Text);
                        objWriter.Write("\n");
                        objWriter.Write("Address: " + caddress.Text);
                        objWriter.Write("\n");
                        objWriter.Write("Gender: " + Genderr);
                        objWriter.Write("\n");
                        objWriter.Write("VIP: " + cviplevel.Text);
                        objWriter.Write("\n");
                        objWriter.Write("Interest: " + cinterestedproducts.Text);
                        objWriter.Write("\n");
                        objWriter.Write("Hobby: " + check);

                    }

                    MessageBox.Show("Details have been saved");


                }


                MessageBox.Show("Name: " + cname.Text + "\nAge: " + cage.Text + "\nAddress: " + caddress.Text + "\nGender: " + Genderr + "\nVip Level: " + cviplevel.Text + "\nInterested Products: " + cinterestedproducts.Text + "\nGeneral Hobbies: " + check);
            }
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            Genderr = "Male";
        }

        private void d_Enter(object sender, EventArgs e)
        {

        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            Genderr = "Female";
        }

        private void add_TextChanged(object sender, EventArgs e)
        {

        }

        private void cname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cname.Text))
            {
                e.Cancel = true;
                cname.Focus();
                errorProvidern.SetError(cname, "Name can not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvidern.SetError(cname, "");
            }
        }

        private void cage_Validating(object sender, CancelEventArgs e)
        {
            int val = 0;
            Int32.TryParse(cage.Text, out val);
            if (string.IsNullOrWhiteSpace(cage.Text))
            {
                e.Cancel = true;
                cage.Focus();
                errorProvidern.SetError(cage, "Age can not be left blank!");

            }
            else if (val < 7 | val > 150)
            {

                e.Cancel = true;
                cage.Focus();
                errorProvidern.SetError(cage, "Customer age should be greater than 7 and less then 150!!");

            }
            else

            {
                e.Cancel = false;
                errorProvidern.SetError(cage, "");
            }
        }

        private void caddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(caddress.Text))
            {
                e.Cancel = true;
                caddress.Focus();
                errorProvidern.SetError(caddress, "Address can not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvidern.SetError(caddress, "");
            }
        }

        private void cgender_Validating(object sender, CancelEventArgs e)
        {
            if (Male.Checked || Female.Checked)
            {
                e.Cancel = false;
                errorProvidern.SetError(cgender, "");
            }

            else
            {
                e.Cancel = true;
                cgender.Focus();
                errorProvidern.SetError(cgender, "Choose one!");

            }
        }

        private void cviplevel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cviplevel.Text))
            {
                e.Cancel = true;
                cviplevel.Focus();
                errorProvidern.SetError(cviplevel, "Select VIP Level!");
            }
            else
            {
                e.Cancel = false;
                errorProvidern.SetError(cviplevel, "");
            }
        }

        private void cinterestedproducts_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cinterestedproducts.Text))
            {
                e.Cancel = true;
                cinterestedproducts.Focus();
                errorProvidern.SetError(cinterestedproducts, "Interest can not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvidern.SetError(cinterestedproducts, "");
            }
        }
    }
}
