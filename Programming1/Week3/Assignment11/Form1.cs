using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment11
{
    public partial class frm11 : Form
    {
        public frm11()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            double avg = (num1 + num2) / 2;
            double high;
            double dif;

            if (num1 > num2)
            {
                high = num1;
                dif = num1 - avg;
            }
            else
            {
                high = num2;
                dif = num2 - avg;
            }

            lblAvg.Text = avg.ToString("0.#");
            lblDif.Text = dif.ToString("0.#");
            lblHigh.Text = high.ToString();
        }
    }
}
