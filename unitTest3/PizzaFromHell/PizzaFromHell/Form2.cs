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
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        string username = "";
        public Form2()
        {
            InitializeComponent();
        }

        public void playWithCheckData()
        {
            int sauce = rnd.Next(3);
            int crust = rnd.Next(3);

            var crustButtons = groupCrust.Controls.OfType<RadioButton>();
            crustButtons.ElementAt(crust).Checked = true;

            var sauceButtons = groupSauce.Controls.OfType<RadioButton>();
            sauceButtons.ElementAt(sauce).Checked = true;

            int[] addons = { rnd.Next(2), rnd.Next(2), rnd.Next(2), rnd.Next(2), rnd.Next(2), rnd.Next(2), rnd.Next(2) };

            var addonButtons = groupAddons.Controls.OfType<CheckBox>();

            for (int i = 0; i < addons.Length; i++)
            {
                if (addons[i] == 0)
                    addonButtons.ElementAt(i).Checked = false;
                else
                    addonButtons.ElementAt(i).Checked = true;
            }
        }

        public void playWithInputData()
        {
            string dimensions = "";
            dimensions = rnd.Next(20, 40).ToString();
            textDimensions.Text = dimensions;

            string quantity = "";
            quantity = rnd.Next(1, 21).ToString();
            textQuantity.Text = quantity;

            string cardNumber = "5425";
            for (int i = 0; i < 12; i++)
                cardNumber += rnd.Next(10).ToString();
            textCard.Text = cardNumber;
        }

        public bool checkFields()
        {
            bool valid = true;
            var fields = this.Controls.OfType<TextBox>();
            foreach(var field in fields)
            {
                if (field.Text.Length < 2)
                    valid = false;
            }
            return valid;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.StartPosition = FormStartPosition.Manual;
            form3.Location = new Point(950, 150);
            form3.Show();
            progressBar1.Value = 100;
            string[] logins = File.ReadAllLines(@"logins.txt");
            username = logins[logins.Length - 1];
            this.title.Text += username;

            Color colorCrust = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            Color colorSauce = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            Color colorAddons = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            Color colorLabels = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            Color colorTitle = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            groupAddons.BackColor = colorAddons;
            groupCrust.BackColor = colorCrust;
            groupSauce.BackColor = colorSauce;

            var labels = Controls.OfType<Label>().Where(label => label.Name.StartsWith("label"));

            foreach (var label in labels)
                label.BackColor = colorLabels;

            title.BackColor = colorTitle;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            --progressBar1.Value;
            if (progressBar1.Value == 0)
            {
                timer1.Stop();
                if (checkFields())
                    MessageBox.Show("Thank you for your order!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("You are on the blacklist now!", "Blacklist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    StreamWriter sw = new StreamWriter(@"blacklist.txt", true);
                    sw.WriteLine(username);
                    sw.Close();
                }
                Application.Exit();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            playWithCheckData();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            playWithInputData();
        }

        private void buttonEscape_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                MessageBox.Show("You are on the blacklist now!", "Blacklist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StreamWriter sw = new StreamWriter(@"blacklist.txt", true);
                sw.WriteLine(username);
                sw.Close();
                Application.Exit();
            }
        }

        private void textCard_MouseEnter(object sender, EventArgs e)
        {
            if (timer3.Enabled)
            {
                timer3.Stop();
                timer3.Enabled = false;
                var fields = this.Controls.OfType<TextBox>();
                foreach (var field in fields)
                    field.Text = "";
            }
           
        }
    }
}