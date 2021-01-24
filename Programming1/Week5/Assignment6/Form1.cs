using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();            
        }

        string msg = "";
        int[] before = new int[20];
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 20; i++)
            {
                before[i] = rnd.Next(0, 500);
                msg += "Element " + i.ToString("00") + " = " + before[i] + "\n";
            }
            lblBefore.Text = msg;
        }

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (int.TryParse(txtCompare.Text, out int numCompare))
            {
                if(int.TryParse(txtHigher.Text, out int higher))
                {
                    if(int.TryParse(txtLower.Text, out int lower))
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            if (before[i] > numCompare)
                            {
                                before[i] += higher;
                            }
                            else if (before[i] < numCompare)
                            {
                                before[i] += lower;
                            }
                            msg += "Element " + i.ToString("00") + " = " + before[i] + "\n";
                        }
                        lblAfter.Text = "";
                        lblAfter.Text = msg;
                    }
                    else
                    {
                        MessageBox.Show("The lower number should be an integer", "Error lower input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLower.Clear();
                        txtLower.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("The higher number should be an integer!", "Error higher input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHigher.Clear();
                    txtLower.Focus();
                }
            }
            else
            {
                MessageBox.Show("The Comparison number should be an integer!", "Error comparison input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCompare.Clear();
                txtCompare.Focus();
            }
        }
    }
}
