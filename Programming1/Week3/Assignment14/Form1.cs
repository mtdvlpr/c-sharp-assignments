using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment14
{
    public partial class frm14 : Form
    {
        public frm14()
        {
            InitializeComponent();
        }

        private void BtnMale_Click(object sender, EventArgs e)
        {
            double length = double.Parse(txtLength.Text) / 100;
            double weight = double.Parse(txtWeight.Text);
            double weightMin;
            double weightMax;

            double bmi = weight / (length * length);           
            weightMin = 20 * length * length;
            weightMax = 25 * length * length;

            lblBMI.Text = bmi.ToString("0.#");
            lblNormal.Text = "20 - 25";
            lblWeight.Text = weightMin.ToString("0.#") + " - " + weightMax.ToString("0.#");
        }

        private void BtnFemale_Click(object sender, EventArgs e)
        {
            double length = double.Parse(txtLength.Text) / 100;
            double weight = double.Parse(txtWeight.Text);
            double weightMin;
            double weightMax;

            double bmi = weight / (length * length);
            weightMin = 19 * length * length;
            weightMax = 24 * length * length;

            lblBMI.Text = bmi.ToString("0.#");
            lblNormal.Text = "19 - 24";
            lblWeight.Text = weightMin.ToString("0.0") + " - " + weightMax.ToString("0.#");
        }
    }
}
