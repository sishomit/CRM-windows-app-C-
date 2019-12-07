using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int c = 3;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (username.Text == "shomit" && pwd.Text == "123456")
            {
                this.Hide();
                Datamenu ss = new Datamenu();
                ss.Show();

            }
            else
            {
                c--;
                if (c == 0)
                {
                    MessageBox.Show("Sorry! Too many wrong attempts!");
                    this.Close();
                }
                username.Text = "";
                pwd.Text = "";
                MessageBox.Show("Invalid User Name or Password\n" + (c) + "Chance left\nTry Again!");


            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
