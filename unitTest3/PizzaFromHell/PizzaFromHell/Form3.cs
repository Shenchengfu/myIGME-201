using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaFromHell
{
    public partial class Form3 : Form
    {
        Random random = new Random();
        System.Media.SoundPlayer player;

        public Form3()
        {
            InitializeComponent();
            player = new System.Media.SoundPlayer(@"nervous.wav");
            player.Play();
            player.PlayLooping();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String[] phrases = { "Hurry Up!", "You are \nso slow!!!", "I'm hungry \ntoo!!!", "Booooring!" ,
                                 "I need a\nraise!!!", "C'mon,\nwrap it up!", "It's been\na century!",
                                 "I'm tired\nof waiting!", "See you \non blacklist"};
            int i = random.Next(phrases.Length);
            label1.Text = phrases[i];
        }
    }
}
