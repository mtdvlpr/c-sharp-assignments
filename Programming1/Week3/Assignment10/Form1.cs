using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment10
{
    public partial class frm10 : Form
    {
        public frm10()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            const double RAISE = 0.05;
            double salary = double.Parse(txtSalary.Text);

            double raise = salary * RAISE;

            if (raise < 75)
            {
                raise = 75;
            }

            double newSalary = salary + raise;

            lblRaise.Text = "€ " + raise.ToString("0.00");
            lblNew.Text = "€ " + newSalary.ToString("0.00");
        }
    }
}
