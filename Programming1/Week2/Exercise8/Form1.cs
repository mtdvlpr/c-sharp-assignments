using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            const double VAT = 0.21;
            const int PRICE_SHIRTS = 30;
            const int PRICE_JEANS = 100;

            int NumShirts = int.Parse(txtShirts.Text);
            int NumJeans = int.Parse(txtJeans.Text);

            string date = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
            double price = PRICE_JEANS * NumJeans + PRICE_SHIRTS * NumShirts;
            double vat = price * VAT;
            double total = price + vat;

            lblDate.Text = date;
            lblPrice.Text = "€ " + price.ToString("0.00");
            lblVAT.Text = "€ " + vat.ToString("0.00");
            lblTotal.Text = "€ " + total.ToString("0.00");
        }
    }
}
