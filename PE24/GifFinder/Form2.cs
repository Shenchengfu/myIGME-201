using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GifFinder
{
    public partial class SearchForm : Form
    {
        public string response;
        public string searchTerm;
        public int maxItems;
        public SearchForm()
        {
            InitializeComponent();
            this.OKButton.Click += new EventHandler(OKButton_Click);
            this.cancelButton.Click += new EventHandler(CancelButton_Click);
            this.MaxItemsTextBox.KeyPress += new KeyPressEventHandler(this.MaxItemsTextBox_KeyPress);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.response = "Cancel";
            this.Hide();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.response = "OK";
            this.searchTerm = SearchTermTextBox.Text;
            this.maxItems = Convert.ToInt32(MaxItemsTextBox.Text);
            this.Hide();
        }

        private void MaxItemsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }
    }
}
