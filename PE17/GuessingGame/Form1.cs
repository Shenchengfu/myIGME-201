using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int lowNumber = 0;
            int highNumber = 0;

            lowNumber = Int32.Parse(lowTextBox.Text);
            highNumber = Int32.Parse(highTextBox.Text);

            if (lowNumber >= highNumber)
            {
                MessageBox.Show("The numbers are invalid!");
            }
            else
            {
                GameForm gameForm = new GameForm(lowNumber, highNumber);
                gameForm.ShowDialog();
            }
        }

        private void lowTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                MessageBox.Show("Please enter digits only!");
                e.Handled = true;
            }
        }

        private void highTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                MessageBox.Show("Please enter digits only!");
                e.Handled = true;
            }
        }
    }
}
