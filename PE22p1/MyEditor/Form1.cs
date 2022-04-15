using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.newToolStripMenuItem.Click += new EventHandler(newToolStripMenuItem_Click);
            this.openToolStripMenuItem.Click += new EventHandler(openToolStripMenuItem_Click);
            this.saveToolStripMenuItem.Click += new EventHandler(saveToolStripMenuItem_Click);
            this.exitToolStripMenuItem.Click += new EventHandler(exitToolStripMenuItem_Click);

            this.copyToolStripMenuItem.Click += new EventHandler(copyToolStripMenuItem_Click);
            this.cutToolStripMenuItem.Click += new EventHandler(cutToolStripMenuItem_Click);
            this.pasteToolStripMenuItem.Click += new EventHandler(pasteToolStripMenuItem_Click);

            this.boldToolStripMenuItem.Click += new EventHandler(BoldToolStripMenuItem_Click);
            this.italicsToolStripMenuItem.Click += new EventHandler(ItalicsToolStripMenuItem_Click);
            this.underlineToolStripMenuItem.Click += new EventHandler(UnderlineToolStripMenuItem_Click);

            this.mSSansSerifToolStripMenuItem.Click += new EventHandler(MSSansSerifToolStripMenuItem_Click);
            this.timesNewRomanToolStripMenuItem.Click += new EventHandler(TimesNewRomanToolStripMenuItem_Click);

            this.toolStrip.ItemClicked += new ToolStripItemClickedEventHandler(toolStrip_ItemClicked);
            this.richTextBox.SelectionChanged  += new EventHandler(MSSansSerifToolStripMenuItem_Click);
            this.Text = "MyEditor";

        }

        private void RichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            if (this.richTextBox.SelectionFont != null)
            {
                this.boldToolStripButton.Checked = richTextBox.SelectionFont.Bold;
                this.boldToolStripButton.Checked = richTextBox.SelectionFont.Italic;
                this.boldToolStripButton.Checked = richTextBox.SelectionFont.Underline;
            }

            this.colorToolStripButton.BackColor = richTextBox.SelectionColor;

        }
        private void BoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Bold;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            if(selectionFont == null)
                selectionFont = richTextBox.Font;

            SetSelectionFont(fontStyle, !selectionFont.Bold);
        }

        private void ItalicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Italic;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            if (selectionFont == null)
                selectionFont = richTextBox.Font;

            SetSelectionFont(fontStyle, !selectionFont.Italic);
        }

        private void UnderlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Underline;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            if (selectionFont == null)
                selectionFont = richTextBox.Font;

            SetSelectionFont(fontStyle, !selectionFont.Underline);
        }

        private void MSSansSerifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font newFont = new Font("MS Sans Serif", richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);
            richTextBox.SelectionFont = newFont;
        }

        private void TimesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font newFont = new Font("Timew New Roman", richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);
            richTextBox.SelectionFont = newFont;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            this.Text = "MyEditor";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;

                if (openFileDialog.FileName.ToLower().Contains(".txt"))
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;

                richTextBox.LoadFile(openFileDialog.FileName, richTextBoxStreamType);

                this.Text = "My Editor (" + openFileDialog.FileName + ")";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = saveFileDialog.FileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;

                if (openFileDialog.FileName.ToLower().Contains(".txt"))
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;

                richTextBox.SaveFile(saveFileDialog.FileName, richTextBoxStreamType);

                this.Text = "My Editor (" + saveFileDialog.FileName + ")";
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;

            ToolStripButton toolStripButton = null;
            if (e.ClickedItem == this.boldToolStripButton)
            {
                fontStyle = FontStyle.Bold;
                toolStripButton = this.boldToolStripButton;
            }
            else if (e.ClickedItem == this.italicsToolStripButton)
            {
                fontStyle = FontStyle.Italic;
                toolStripButton = this.italicsToolStripButton;
            }
            else if (e.ClickedItem == this.underlineToolStripButton)
            {
                fontStyle = FontStyle.Underline;
                toolStripButton = this.underlineToolStripButton;
            }
            else if (e.ClickedItem == this.colorToolStripButton)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SelectionColor = colorDialog.Color;
                    colorToolStripButton.BackColor = colorDialog.Color;
                }
            }

            if (fontStyle != FontStyle.Regular)
            {
                toolStripButton.Checked = !toolStripButton.Checked;

                SetSelectionFont(fontStyle, toolStripButton.Checked);
            }
        }

        private void SetSelectionFont(FontStyle fontStyle, bool bSet)
        {
            Font newFont = null;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            if (bSet)
            {
                newFont = new Font(selectionFont, selectionFont.Style | fontStyle);        
            }
            else
            {
                newFont = new Font(selectionFont, selectionFont.Style & ~fontStyle);
            }

            this.richTextBox.SelectionFont = newFont;
        }

    }
}
