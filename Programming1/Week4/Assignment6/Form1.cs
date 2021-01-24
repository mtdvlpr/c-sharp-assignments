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

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            const double INTEREST = 0.05;
            double amount = 0;
            double years = 0;

            if (double.TryParse(txtAmount.Text, out amount))
            {
                if (double.TryParse(txtYears.Text, out years))
                {
                    if (years >= 0)
                    {
                        for (int timer = 0; timer < years; timer++)
                        {
                            amount *= (1 + INTEREST);
                        }
                        lblFinal.Text = amount.ToString(" € 0.00");
                    }
                    else
                    {
                        MessageBox.Show("The years input should be a positive number!", "Error years input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtYears.Clear();
                        txtYears.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("The years input is not valid!", "Error years input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtYears.Clear();
                    txtYears.Focus();
                }
            }
            else
            {
                MessageBox.Show("The amount input is not valid!", "Error amount input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Clear();
                txtAmount.Focus();
            }
        }
    }
}
