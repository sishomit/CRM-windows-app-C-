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
    public partial class serachcustomer : Form
    {
        public serachcustomer()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filename = null;
            Console.WriteLine("Enter Customer Name : ");
            filename = "d:\\csharp\\customer\\customer_"+scname.Text+".txt";
            if (File.Exists(filename))
            {
                string text = File.ReadAllText("d:\\csharp\\customer\\customer_" + scname.Text + ".txt");
                MessageBox.Show("Customer Information:\n" + text);
            }
            else MessageBox.Show("Sorry Customer Couldn't Found.\nSearch Again");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
