using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            double result;

            if(int.TryParse(txtNum1.Text, out num1))
            {
                if(int.TryParse(txtNum2.Text, out num2))
                {
                    result = Plus(num1, num2);
                    lblResult.Text = result.ToString("0.###");
                }
                else
                {
                    MessageBox.Show("Number 2 should be an integer!", "Error number 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNum2.Clear();
                    txtNum2.Focus();
                }
            }
            else
            {
                MessageBox.Show("Number 1 should be an integer!", "Error number 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum1.Clear();
                txtNum1.Focus();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            double result;

            if (int.TryParse(txtNum1.Text, out num1))
            {
                if (int.TryParse(txtNum2.Text, out num2))
                {
                    result = Minus(num1, num2);
                    lblResult.Text = result.ToString("0.###");
                }
                else
                {
                    MessageBox.Show("Number 2 should be an integer!", "Error number 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNum2.Clear();
                    txtNum2.Focus();
                }
            }
            else
            {
                MessageBox.Show("Number 1 should be an integer!", "Error number 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum1.Clear();
                txtNum1.Focus();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            double result;

            if (int.TryParse(txtNum1.Text, out num1))
            {
                if (int.TryParse(txtNum2.Text, out num2))
                {
                    result = Times(num1, num2);
                    lblResult.Text = result.ToString("0.###");
                }
                else
                {
                    MessageBox.Show("Number 2 should be an integer!", "Error number 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNum2.Clear();
                    txtNum2.Focus();
                }
            }
            else
            {
                MessageBox.Show("Number 1 should be an integer!", "Error number 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum1.Clear();
                txtNum1.Focus();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            double result;

            if (int.TryParse(txtNum1.Text, out num1))
            {
                if (int.TryParse(txtNum2.Text, out num2))
                {
                    if (num2 != 0)
                    {
                        result = Divide(num1, num2);
                        lblResult.Text = result.ToString("0.###");
                    }
                    else
                    {
                        MessageBox.Show("Number 2 can't be 0!", "Error divide by 0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNum2.Clear();
                        txtNum2.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Number 2 should be an integer!", "Error number 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNum2.Clear();
                    txtNum2.Focus();
                }
            }
            else
            {
                MessageBox.Show("Number 1 should be an integer!", "Error number 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum1.Clear();
                txtNum1.Focus();
            }
        }

        static int Plus(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Minus(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Times(int num1, int num2)
        {
            return num1 * num2;
        }

        static double Divide(int num1, int num2)
        {
            return (double) num1 / num2;
        }
    }
}
