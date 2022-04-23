using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PizzaFromHell
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player = new System.Media.SoundPlayer(@"intro.wav");
            player.Play();
            player.PlayLooping();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            if(username == "" || username == " Username")
                MessageBox.Show("Please enter your username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           else {
                string[] blacklist = File.ReadAllLines(@"blacklist.txt");
                bool found = false;
                foreach(string black in blacklist)
                {
                    if(black == username)
                    {
                        MessageBox.Show("You are on the blacklist!", "Blacklist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        found = true;
                        Application.Exit();
                    }

                }
                if (!found)
                {
                    StreamWriter sw = new StreamWriter(@"logins.txt");
                    sw.WriteLine(username);
                    sw.Close();
                    this.Hide();
                    player.Stop();
                    var form2 = new Form2();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
            }
        }
    }
}
