using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment9
{
    public partial class frm9 : Form
    {
        public frm9()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            int fee;
            int age = int.Parse(txtAge.Text);
            int duration = int.Parse(txtDuration.Text);

            if (radFootball.Checked)
            {
                fee = 175;
            }
            else
            {
                fee = 225;
            }

            if (age>40)
            {
                fee -= 25;
            }

            if (duration > 10)
            {
                fee -= 20;
            }

            lblPrice.Text = "€ " + fee.ToString("0.00");
        }
    }
}
