using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_re
{
    public partial class BookInfoForm : Form
    {
        string GetTitle;

        public BookInfoForm(string btitle)
        {
            InitializeComponent();
            this.GetTitle = btitle;
            txt_booksearch.Text = GetTitle;
        }

        private void bt_booksearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetTitle);
        }
    }
}
