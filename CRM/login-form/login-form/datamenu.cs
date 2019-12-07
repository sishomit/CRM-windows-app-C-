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
    public partial class Datamenu : Form
    {
        //private TextBox textBox1;

        public Datamenu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Customer Relationship Managment Software developed by Shomit.Here you can save your customer and staff list with their info and read them");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Student_Click(object sender, EventArgs e)
        {
            staff ss = new staff();
            ss.Show();
        }

        private void Faculty_Click(object sender, EventArgs e)
        {
           Customer ss = new Customer();
            ss.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
            serachcustomer ss = new serachcustomer();
            ss.Show();

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
            searchstaff ss = new searchstaff();
            ss.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Data_Entry_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
