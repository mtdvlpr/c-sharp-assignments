using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment12
{
    public partial class frm12 : Form
    {
        public frm12()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            const double BASIC = 12;
            int age = int.Parse(txtAge.Text);
            double price = 0;

            if (age <0)
            {
                MessageBox.Show("Your age can't be below 0!");
            }
            else if (age >= 5 && age <= 12)
            {
                price = 0.5 * BASIC;
            }
            else if (age >= 13 && age <= 54)
            {
                price = BASIC;
            }

            lblPrice.Text = "€ " + price.ToString("0.00");
        }
    }
}
