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
    public partial class GameForm : Form
    {
        int nRand = 0;
        int nGuesses = 0;

        public GameForm(int low, int high)
        {
            InitializeComponent();

            Random rand = new Random();
            nRand = rand.Next(low, high + 1);

            this.AcceptButton = btnGuess;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 500;
            progressBar1.Maximum = 100;
            progressBar1.Value = 100;
            timer1.Tick += new EventHandler(timer1_Tick);

        }

        private void guessTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                MessageBox.Show("Please enter digits only!");
                e.Handled = true;
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            nGuesses++;
            int guess = Int32.Parse(guessTextBox.Text);
            if (guess == nRand)
            {
                timer1.Stop();
                MessageBox.Show($"Woohoo, you got it in {nGuesses} guesses!");
                this.Close();
            }
            else if (guess < nRand)
                MessageBox.Show($"Your guess {guess} was LOW!");
            else
                MessageBox.Show($"Your guess {guess} was HIGH!");
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 0)
            {
                progressBar1.Value--;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show($"Out of time! The answer was {nRand}");
                this.Close();
            }
        }
    }
}
