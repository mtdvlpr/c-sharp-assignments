using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            int s;
            int n;
            int sum1 = 0;
            int sum2 = 0;
            int timer;

            if (int.TryParse(txtNumber.Text, out n))
            {
                if (int.TryParse(txtStart.Text, out s))
                {
                    timer = s;
                    if (n >= 0 && s >= 0)
                    {
                        if (n >= s)
                        {
                            while (timer <= n)
                            {
                                sum1 += timer;
                                timer++;
                            }
                            sum2 = (n * (n + 1) / 2) - ((s - 1) * ((s - 1) + 1) / 2);

                            lblNum1.Text = sum1.ToString();
                            lblNum2.Text = sum2.ToString();

                            if (sum1 == sum2)
                            {
                                lblResult.Text = "The sum and formula are equal.";
                            }
                            else
                            {
                                lblResult.Text = "The sum and formula are NOT equal.";
                            }
                        }
                        else
                        {
                            MessageBox.Show("n should be higher than s!", "Error input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNumber.Clear();
                            txtStart.Clear();
                            txtNumber.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("s & n should be 0 or more!", "Error input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNumber.Clear();
                        txtStart.Clear();
                        txtNumber.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("The start input is invalid!", "Error start input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtStart.Clear();
                    txtStart.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("The number input is invalid!", "Error number input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.Clear();
                txtNumber.Focus();
            }
        }
    }
}
