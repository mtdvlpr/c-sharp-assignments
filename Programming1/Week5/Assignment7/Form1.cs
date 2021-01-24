using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnThrow_Click(object sender, EventArgs e)
        {
            int times;
            int number;
            int[] dice = new int[6];
            Random rnd = new Random();
            const string TXT = "Number of throws of value ";

            if (int.TryParse(txtNumber.Text, out times) && times >= 0 && times <= 10000)
            {
                for (int i = 0; i < times; i++)
                {
                    number = rnd.Next(1, 7);
                    dice[number - 1]++;
                }
                lbl1.Text = TXT + "1 = " + dice[0];
                lbl2.Text = TXT + "2 = " + dice[1];
                lbl3.Text = TXT + "3 = " + dice[2];
                lbl4.Text = TXT + "4 = " + dice[3];
                lbl5.Text = TXT + "5 = " + dice[4];
                lbl6.Text = TXT + "6 = " + dice[5];
            }
            else
            {
                MessageBox.Show("The number of throws should be a positive integer between 0 and 10,000!", "Error number of throws input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.Clear();
                txtNumber.Focus();
            }
        }
    }
}
