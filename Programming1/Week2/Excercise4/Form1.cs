using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVAT_Click(object sender, EventArgs e)
        {
            const double VAR = 0.21;
            double price = double.Parse(txtPrice.Text);
            double vat = price * VAR;
            double total = price + vat;

            lblPrice.Text = price.ToString("0.00");
            lblVAT.Text = vat.ToString("0.00");
            lblTotal.Text = total.ToString("0.00");
        }
    }
}
