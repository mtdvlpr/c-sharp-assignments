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

        private void Button1_Click(object sender, EventArgs e)
        {

            if(double.TryParse(txtDegrees.Text, out double degrees))
            {
                double result;

                if (radFromCelsius.Checked)
                {
                    if (degrees < -273)
                    {
                        MessageBox.Show("Your temperature must be above or equal to Absolute Zero (-273 °C)!", "Error temperature", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (radToFahrenheit.Checked)
                    {
                        result = CtoF(degrees);
                        lblResult.Text = result.ToString("0.##") + " °F";
                    }
                    else if (radToKelvin.Checked)
                    {
                        result = CtoK(degrees);
                        lblResult.Text = result.ToString("0.##") + " K";
                    }
                    else if (radToCelsius.Checked)
                    {
                        lblResult.Text = degrees.ToString("0.##") + " °C";
                    }
                    else
                    {
                        MessageBox.Show("Select a to unit!", "Error to unit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (radFromFahrenheit.Checked)
                {
                    if (degrees < -459.4)
                    {
                        MessageBox.Show("Your temperature must be above or equal to Absolute Zero (-459.4 °F)!", "Error temperature", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (radToCelsius.Checked)
                    {
                        result = FtoC(degrees);
                        lblResult.Text = result.ToString("0.##") + " °C";
                    }
                    else if (radToKelvin.Checked)
                    {
                        result = FtoK(degrees);
                        lblResult.Text = result.ToString("0.##") + " K";
                    }
                    else if (radToFahrenheit.Checked)
                    {
                        lblResult.Text = degrees.ToString("0.##") + " °F";
                    }
                    else
                    {
                        MessageBox.Show("Select a to unit!", "Error to unit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (radFromKelvin.Checked)
                {
                    if (degrees < 0)
                    {
                        MessageBox.Show("Your temperature must be above or equal to Absolute Zero (0 K)!", "Error temperature", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (radToCelsius.Checked)
                    {
                        result = KtoC(degrees);
                        lblResult.Text = result.ToString("0.##") + " °C";
                    }
                    else if (radToFahrenheit.Checked)
                    {
                        result = KtoF(degrees);
                        lblResult.Text = result.ToString("0.##") + " °F";
                    }
                    else if (radToKelvin.Checked)
                    {
                        lblResult.Text = degrees.ToString("0.##") + " K";
                    }
                    else
                    {
                        MessageBox.Show("Select a to unit!", "Error to unit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Select a from and to unit!", "Error units", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The number of degrees should be an integer!", "Error degrees", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDegrees.Clear();
                txtDegrees.Focus();
            }
        }

        double CtoK(double d)
        {
            return d + 273;
        }

        double KtoC(double d)
        {
            return d - 273;
        }

        double CtoF(double d)
        {
            return d * 9 / 5 + 32;
        }

        double FtoC(double d)
        {
            return (d - 32) * 5 / 9;
        }

        double KtoF(double d)
        {
            return (d-273) * 9 / 5 + 32;
        }

        double FtoK(double d)
        {
            return (d - 32) * 5 / 9 + 273;
        }
    }
}
