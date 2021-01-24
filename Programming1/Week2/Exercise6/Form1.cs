using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCal_Click(object sender, EventArgs e)
        {
            int sec = int.Parse(txtSec.Text);
            int hours = sec / 3600;
            sec %= 3600;
            int min = sec / 60;
            sec %= 60;

            string hours2 = hours.ToString("00");
            string min2 = min.ToString("00");
            string sec2 = sec.ToString("00");

            lblTime.Text = hours2 + ":" + min2 + ":" + sec2;
        }
    }
}
