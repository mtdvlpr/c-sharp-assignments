using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnErase_Click(object sender, EventArgs e)
        {
            txtStart.Clear();
            txtEnd.Clear();
            txtPrice.Clear();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            const double VAT = 0.21;

            int start = int.Parse(txtStart.Text);
            int end = int.Parse(txtEnd.Text);
            double price = double.Parse(txtPrice.Text);

            int km = end - start;
            double excl = price * km;
            double vat = excl * VAT;
            double total = excl + vat;

            lblExcl.Text = excl.ToString("0.00");
            lblVAT.Text = vat.ToString("0.00");
            lblTotal.Text = total.ToString("0.00");
        }
    }
}
