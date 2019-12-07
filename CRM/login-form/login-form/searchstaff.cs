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
    public partial class searchstaff : Form
    {
        public searchstaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filename = null;
    
            filename = "d:\\csharp\\staff\\staff_" + ssname.Text + ".txt";
            if (File.Exists(filename))
            {
                string text = File.ReadAllText("d:\\csharp\\staff\\staff_" + ssname.Text + ".txt");
                MessageBox.Show("Staff Information:\n" + text);
            }
            else MessageBox.Show("Sorry Staff Couldn't Found.\nSearch Again");
        }
    }
}
