using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int side;
            string square = "";

            if (int.TryParse(txtSide.Text, out side))
            {
                if (side < 2 || side > 16)
                {
                    MessageBox.Show("The side input should be at least 2 and not bigger than 16!", "Error side input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSide.Clear();
                    txtSide.Focus();
                }
                else
                {
                    if (!char.TryParse(txtChar.Text, out char character))
                    {
                        MessageBox.Show("The character input is invalid!", "Error character input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtChar.Clear();
                        txtChar.Focus();
                    }
                    else if (character.Equals('&'))
                    {
                        MessageBox.Show("The character input can't be &!", "Error character input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtChar.Clear();
                        txtChar.Focus();
                    }
                    else
                    {
                        for (int timer = 0; timer < side; timer++)
                        {
                            square += character;
                        }
                        square += "\n" + character;

                        for (int timer = 0; timer < (side - 2); timer++)
                        {
                            for (int timer2 = 0; timer2 < (side - 2); timer2++)
                            {
                                square += " ";
                            }
                            square += character + "\n" + character;
                        }
                        for (int timer = 0; timer < (side - 1); timer++)
                        {
                            square += character;
                        }
                        lblSquare.Text = square;
                    }
                }
            }
            else
            {
                MessageBox.Show("The side input is not valid!", "Error side input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSide.Clear();
                txtSide.Focus();
            }
        }
    }
}
