using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment13
{
    public partial class frm13 : Form
    {
        public frm13()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double price = 0;
            double days = double.Parse(txtDays.Text);
            price += days * 55;

            double km = double.Parse(txtKms.Text) - 100 * days;
            if (km > 0)
            {
                price += km * 0.25;
            }

            if (ckbRefuel.Checked)
            {
                double litres = int.Parse(txtLitres.Text);
                price += litres * 2.2;
            }

            lblPrice.Text = "€ " + price.ToString("0.00");
        }
    }
}
