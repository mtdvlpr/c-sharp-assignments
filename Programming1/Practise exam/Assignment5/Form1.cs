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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int hours;
            int mins;
            int seconds;
            double totalHours;
            int distance = 0;

            if (int.TryParse(txtHours.Text, out hours) && hours >= 0) 
            {
                if (int.TryParse(txtMinutes.Text, out mins) && mins >= 0)
                {
                    if(int.TryParse(txtSeconds.Text, out seconds) && seconds >= 0)
                    {
                        seconds += hours * 3600 + mins * 60;
                        totalHours = (double) seconds / 3600;

                        if (rad5km.Checked)
                        {
                            distance = 5;
                        }
                        else if (rad10km.Checked)
                        {
                            distance = 10;
                        }
                        else if (rad21km.Checked)
                        {
                            distance = 21;
                        }
                        else
                        {
                            MessageBox.Show("You must choose a certain distance!", "Error Distance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        double result = distance / totalHours;
                        lblResult.Text = result.ToString("0.###") + " km/h";
                    }
                    else
                    {
                        MessageBox.Show("The number of seconds should be a positive integer!", "Error Seconds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The number of minutes should be a positive integer!", "Error Minutes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The number of hours should be a positive integer!", "Error Hours", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
