using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class frmMenu : Form
    {
        Assignment1.Program f1 = new Assignment1.Program();
        Assignment2.Program f2 = new Assignment2.Program();
        Assignment3.Program f3 = new Assignment3.Program();
        Assignment4.Program f4 = new Assignment4.Program();
        Assignment5.Program f5 = new Assignment5.Program();
        Assignment6.Program f6 = new Assignment6.Program();
        Assignment7.Program f7 = new Assignment7.Program();
        Assignment8.Program f8 = new Assignment8.Program();

        Assignment9.frm9 f9 = new Assignment9.frm9();
        Assignment10.frm10 f10 = new Assignment10.frm10();
        Assignment11.frm11 f11 = new Assignment11.frm11();
        Assignment12.frm12 f12 = new Assignment12.frm12();
        Assignment13.frm13 f13 = new Assignment13.frm13();
        Assignment14.frm14 f14 = new Assignment14.frm14();


        public frmMenu()
        {
            InitializeComponent();
        }

        private void Assignment1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Assignment9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f9.Show();
        }

        private void Assignment10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f10.Show();
        }

        private void Assignment11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f11.Show();
        }

        private void Assignment12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f12.Show();
        }

        private void Assignment13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f13.Show();
        }

        private void Assignment14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f14.Show();
        }
    }
}
