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

        private void BtnRef_Click(object sender, EventArgs e)
        {
            double num;
            string i = "";

            if(double.TryParse(txtNumber.Text, out num))
            {
                if (radSquare.Checked)
                {
                    SquareByReference(ref num);
                }
                else
                {
                    if(num < 0)
                    {
                        num *= -1;
                        i = "i";
                    }
                    RootByReference(ref num);
                }
                lblResult.Text = num.ToString("0.##") + i;
            }
            else
            {
                MessageBox.Show("The number should be an integer!", "Error number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.Clear();
                txtNumber.Focus();
            }

        }

        private void BtnRefOut_Click(object sender, EventArgs e)
        {
            int num;
            double result;
            string i = "";

            if (int.TryParse(txtNumber.Text, out num))
            {
                if (radSquare.Checked)
                {
                    SquareByReferenceOut(ref num, out result);
                }
                else
                {
                    if (num < 0)
                    {
                        num *= -1;
                        i = "i";
                    }
                    RootByReferenceOut(ref num, out result);
                }
                lblResult.Text = result.ToString("0.##") + i;
            }
            else
            {
                MessageBox.Show("The number should be an integer!", "Error number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.Clear();
                txtNumber.Focus();
            }
        }

        private void BtnValue_Click(object sender, EventArgs e)
        {
            int num;
            double result;
            string i = "";

            if (int.TryParse(txtNumber.Text, out num))
            {
                if (radSquare.Checked)
                {
                    result = SquareByValue(num);
                }
                else
                {
                    if (num < 0)
                    {
                        num *= -1;
                        i = "i";
                    }
                    result = RootByValue(num);
                }
                lblResult.Text = result.ToString("0.##") + i;
            }
            else
            {
                MessageBox.Show("The number should be an integer!", "Error number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.Clear();
                txtNumber.Focus();
            }
        }

        void SquareByReference(ref double num)
        {
            num *= num;
        }

        void SquareByReferenceOut(ref int num, out double result)
        {
            result = num * num;
        }

        double SquareByValue(int num)
        {
            return num * num;
        }

        void RootByReference(ref double num)
        {
            num = Math.Sqrt(num);
        }

        void RootByReferenceOut(ref int num, out double result)
        {
            result = Math.Sqrt(num);
        }

        double RootByValue(int num)
        {
            return Math.Sqrt(num);
        }
    }
}
