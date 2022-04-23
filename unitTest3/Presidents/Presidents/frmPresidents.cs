using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace Presidents
{
    public partial class frmPresidents : Form
    {
        public frmPresidents()
        {
            InitializeComponent();
            SetControls();
        }

        private void SetControls()
        {
            foreach (Control control in (ArrangedElementCollection)Controls)
            {
                if (control.GetType() == typeof(PictureBox))
                {
                    SetPictureBoxes(control);
                }
                if (control.GetType() == typeof(RadioButton))
                {
                    SetRadioButtons(control);
                }
                if (control.GetType() == typeof(TextBox))
                {
                    SetTextBoxes(control);
                }
            }
            foreach (Control control in (ArrangedElementCollection)groupBox2.Controls)
            {
                SetFilter(control);
            }
            radioButton17.Checked = true;
            radioButton1.Checked = true;
            timer1.Interval = 500;
            timer1.Tick += new EventHandler(Timer__Tick);
            button1.Enabled = false;
            button1.Click += new EventHandler(ButtonExit_Click);
            toolStripProgressBar1.Maximum = 240;
            toolStripProgressBar1.Value = 240;
            pictureBox1.Visible = true;
            pictureBox1.Enabled = true;
            checkBox1.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser1__DocumentCompleted);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            groupBox1.Visible = checkBox.Checked;

            if (checkBox.Checked)
            {
                this.Size = new Size(1000, 689);
            }
            else
            {
                this.Size = new Size(368, 689);
            }
        }

        private void SetPictureBoxes(Control control)
        {
            PictureBox pictureBox = (PictureBox)control;
            pictureBox.MouseEnter += new EventHandler(PicBox__MouseEnter);
            pictureBox.MouseLeave += new EventHandler(PicBox__MouseLeave);
            pictureBox.Visible = false;
            pictureBox.Enabled = false;
        }

        private void SetFilter(Control control)
        {
            if (control.GetType() == typeof(RadioButton))
            {
                RadioButton radioButton = (RadioButton)control;
                radioButton.CheckedChanged += new EventHandler(RadioButtonFilter__CheckedChanged);
                List<RadioButton> radioButtonList = new List<RadioButton>();
                switch (radioButton.Name)
                {
                    case "radioButton17":
                        radioButtonList.Add(radioButton1);
                        radioButtonList.Add(radioButton2);
                        radioButtonList.Add(radioButton3);
                        radioButtonList.Add(radioButton4);
                        radioButtonList.Add(radioButton5);
                        radioButtonList.Add(radioButton6);
                        radioButtonList.Add(radioButton7);
                        radioButtonList.Add(radioButton8);
                        radioButtonList.Add(radioButton9);
                        radioButtonList.Add(radioButton10);
                        radioButtonList.Add(radioButton11);
                        radioButtonList.Add(radioButton12);
                        radioButtonList.Add(radioButton13);
                        radioButtonList.Add(radioButton14);
                        radioButtonList.Add(radioButton15);
                        radioButtonList.Add(radioButton16);
                        break;
                    case "radioButton18":
                        radioButtonList.Add(radioButton3);
                        radioButtonList.Add(radioButton5);
                        radioButtonList.Add(radioButton7);
                        radioButtonList.Add(radioButton8);
                        radioButtonList.Add(radioButton9);
                        radioButtonList.Add(radioButton13);
                        radioButtonList.Add(radioButton15);
                        break;
                    case "radioButton19":
                        radioButtonList.Add(radioButton1);
                        radioButtonList.Add(radioButton2);
                        radioButtonList.Add(radioButton4);
                        radioButtonList.Add(radioButton6);
                        radioButtonList.Add(radioButton11);
                        radioButtonList.Add(radioButton14);
                        break;
                    case "radioButton20":
                        radioButtonList.Add(radioButton16);
                        break;
                    case "radioButton21":
                        radioButtonList.Add(radioButton10);
                        radioButtonList.Add(radioButton12);
                        break;
                }

                radioButton.Tag = (object)radioButtonList;
            }
        }

        private void SetTextBoxes(Control control)
        {
            TextBox textBox = (TextBox)control;
            textBox.Validating += new CancelEventHandler(TextBox__Validating);
            textBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            textBox.Enter += new EventHandler(TextBox__Enter);
            textBox.Click += new EventHandler(TextBox_Click);
            switch (textBox.Name)
            {
                case "textBox1":
                    textBox.Tag = 23;
                    break;
                case "textBox2":
                    textBox.Tag = 25;
                    break;
                case "textBox3":
                    textBox.Tag = 32;
                    break;
                case "textBox4":
                    textBox.Tag = 40;
                    break;
                case "textBox5":
                    textBox.Tag = 42;
                    break;
                case "textBox6":
                    textBox.Tag = 34;
                    break;
                case "textBox7":
                    textBox.Tag = 15;
                    break;
                case "textBox8":
                    textBox.Tag = 8;
                    break;
                case "textBox9":
                    textBox.Tag = 14;
                    break;
                case "textBox10":
                    textBox.Tag = 1;
                    break;
                case "textBox11":
                    textBox.Tag = 43;
                    break;
                case "textBox12":
                    textBox.Tag = 2;
                    break;
                case "textBox13":
                    textBox.Tag = 44;
                    break;
                case "textBox14":
                    textBox.Tag = 26;
                    break;
                case "textBox15":
                    textBox.Tag = 35;
                    break;
                case "textBox16":
                    textBox.Tag = 3;
                    break;
            }
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            SelectText(sender);
        }

        private void TextBox__Enter(object sender, EventArgs e)
        {
            SelectText(sender);
        }

        private static void SelectText(object sender)
        {
            TextBox textBox = (TextBox)sender;
            if (!String.IsNullOrEmpty(textBox.Text))
            {
                textBox.SelectionStart = 0;
                textBox.SelectionLength = textBox.Text.Length;
            }
        }

        private void SetRadioButtons(Control control)
        {
            RadioButton radioButton = (RadioButton)control;
            radioButton.CheckedChanged += new EventHandler(RadioButton__CheckedChanged);
            switch (radioButton.Name)
            {
                case "radioButton1":
                    radioButton.Tag = pictureBox1;
                    break;
                case "radioButton2":
                    radioButton.Tag = pictureBox2;
                    break;
                case "radioButton3":
                    radioButton.Tag = pictureBox3;
                    break;
                case "radioButton4":
                    radioButton.Tag = pictureBox4;
                    break;
                case "radioButton5":
                    radioButton.Tag = pictureBox5;
                    break;
                case "radioButton6":
                    radioButton.Tag = pictureBox6;
                    break;
                case "radioButton7":
                    radioButton.Tag = pictureBox7;
                    break;
                case "radioButton8":
                    radioButton.Tag = pictureBox8;
                    break;
                case "radioButton9":
                    radioButton.Tag = pictureBox9;
                    break;
                case "radioButton10":
                    radioButton.Tag = pictureBox10;
                    break;
                case "radioButton11":
                    radioButton.Tag = pictureBox11;
                    break;
                case "radioButton12":
                    radioButton.Tag = pictureBox12;
                    break;
                case "radioButton13":
                    radioButton.Tag = pictureBox13;
                    break;
                case "radioButton14":
                    radioButton.Tag = pictureBox14;
                    break;
                case "radioButton15":
                    radioButton.Tag = pictureBox15;
                    break;
                case "radioButton16":
                    radioButton.Tag = pictureBox16;
                    break;
            }
        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            groupBox1.Text = webBrowser1.Url.ToString();
            foreach (HtmlElement htmlElement in webBrowser1.Document.GetElementsByTagName("a"))
            {
                htmlElement.SetAttribute("title", "Professor Schuh for President!");
            }
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            --toolStripProgressBar1.Value;
            if (toolStripProgressBar1.Value != 0)
            {
                return;
            }
            timer1.Stop();

            bool completed = true;

            foreach (Control control in (ArrangedElementCollection)Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    completed = completed && control.Text == "0";
                }

                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = "0";
                }
            }

            string message = "Congratulations, you guessed all presidents correctly";
            if (!completed)
            {
                message = "Not all presidents are guessed correctly, keep trying";
            }
            MessageBox.Show(message);

            toolStripProgressBar1.Value = 240;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RadioButtonFilter__CheckedChanged(object sender, EventArgs e)
        {
            List<RadioButton> tag = (List<RadioButton>)((Control)sender).Tag;
            foreach (Control control in (ArrangedElementCollection)Controls)
            {
                if (control.GetType() == typeof(RadioButton))
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (tag.Contains(radioButton))
                    {
                        radioButton.Enabled = true;
                        radioButton.Visible = true;
                        radioButton.Checked = true;
                    }
                    else
                    {
                        radioButton.Enabled = false;
                        radioButton.Visible = false;
                    }
                }
            }
        }

        private void TextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (toolStripProgressBar1.Value == 240)
            {
                timer1.Start();
            }

            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox1 = (TextBox)sender;
            if (textBox1.Text.Length == 0)
                textBox1.Text = "0";
            bool flag = true;
            foreach (Control control in (ArrangedElementCollection)this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox textBox2 = (TextBox)control;
                    if (Convert.ToInt32(textBox2.Text) != (int)textBox2.Tag)
                        flag = false;
                }
            }
            if (flag)
            {
                timer1.Stop();
                button1.Enabled = true;
                webBrowser1.Navigate("https://www.youtube.com/watch?v=18212B4yfLg");
            }
            if (!(textBox1.Text != "0"))
                return;
            errorProvider1.SetError((Control)textBox1, (string)null);
            e.Cancel = false;
            if (Convert.ToInt32(textBox1.Text) != (int)textBox1.Tag)
            {
                errorProvider1.SetError((Control)textBox1, "That is the wrong number.");
                e.Cancel = true;
            }
        }

        private void RadioButton__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            foreach (Control control in (ArrangedElementCollection)Controls)
            {
                if (control.GetType() == typeof(PictureBox))
                {
                    PictureBox pictureBox = (PictureBox)control;
                    if (radioButton.Tag == pictureBox)
                    {
                        pictureBox.Visible = true;
                        pictureBox.Enabled = true;
                    }
                    else
                    {
                        pictureBox.Visible = false;
                        pictureBox.Enabled = false;
                    }
                }
            }
            if (!radioButton.Checked)
            {
                return;
            }
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/" + radioButton.Text);
        }

        private void PicBox__MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Height /= 2;
            pictureBox.Width /= 2;
        }

        private void PicBox__MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Height *= 2;
            pictureBox.Width *= 2;
            pictureBox.BringToFront();
        }
    }


}
